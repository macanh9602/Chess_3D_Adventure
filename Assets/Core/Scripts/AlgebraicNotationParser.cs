using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace ChessMaster.Core
{
    public class AlgebraicNotationParser
    {
        private Board _board;
        private PieceColor _currentTurn;

        public AlgebraicNotationParser(Board board)
        {
            _board = board;
            _currentTurn = PieceColor.White;
        }

        /// <summary>
        /// Parse and apply a sequence of moves from algebraic notation string
        /// </summary>
        /// <param name="moveString">String containing space-separated moves like "d4 d5 c4 e6 Nc3"</param>
        public void ParseAndApplyMoves(string moveString)
        {
            SetupInitialBoard();
            
            string[] moves = moveString.Trim().Split(' ');
            
            foreach (string move in moves)
            {
                if (!string.IsNullOrWhiteSpace(move))
                {
                    ParseAndApplyMove(move.Trim());
                    SwitchTurn();
                }
            }
        }

        /// <summary>
        /// Setup initial chess board position
        /// </summary>
        private void SetupInitialBoard()
        {
            // Clear board
            for (int x = 0; x < Board.Size; x++)
            {
                for (int y = 0; y < Board.Size; y++)
                {
                    _board.Cells[x, y].OccupiedPiece = null;
                }
            }

            // Setup initial position
            // White pieces (bottom ranks)
            _board.Cells[0, 0].OccupiedPiece = new Piece(PieceType.Rook, PieceColor.White, new RookMoveRule());
            _board.Cells[1, 0].OccupiedPiece = new Piece(PieceType.Knight, PieceColor.White, new KnightMoveRule());
            _board.Cells[2, 0].OccupiedPiece = new Piece(PieceType.Bishop, PieceColor.White, new BishopMoveRule());
            _board.Cells[3, 0].OccupiedPiece = new Piece(PieceType.Queen, PieceColor.White, new QueenMoveRule());
            _board.Cells[4, 0].OccupiedPiece = new Piece(PieceType.King, PieceColor.White, new KingMoveRule());
            _board.Cells[5, 0].OccupiedPiece = new Piece(PieceType.Bishop, PieceColor.White, new BishopMoveRule());
            _board.Cells[6, 0].OccupiedPiece = new Piece(PieceType.Knight, PieceColor.White, new KnightMoveRule());
            _board.Cells[7, 0].OccupiedPiece = new Piece(PieceType.Rook, PieceColor.White, new RookMoveRule());

            // White pawns
            for (int x = 0; x < Board.Size; x++)
            {
                _board.Cells[x, 1].OccupiedPiece = new Piece(PieceType.Pawn, PieceColor.White, new PawnMoveRule());
            }

            // Black pieces (top ranks)
            _board.Cells[0, 7].OccupiedPiece = new Piece(PieceType.Rook, PieceColor.Black, new RookMoveRule());
            _board.Cells[1, 7].OccupiedPiece = new Piece(PieceType.Knight, PieceColor.Black, new KnightMoveRule());
            _board.Cells[2, 7].OccupiedPiece = new Piece(PieceType.Bishop, PieceColor.Black, new BishopMoveRule());
            _board.Cells[3, 7].OccupiedPiece = new Piece(PieceType.Queen, PieceColor.Black, new QueenMoveRule());
            _board.Cells[4, 7].OccupiedPiece = new Piece(PieceType.King, PieceColor.Black, new KingMoveRule());
            _board.Cells[5, 7].OccupiedPiece = new Piece(PieceType.Bishop, PieceColor.Black, new BishopMoveRule());
            _board.Cells[6, 7].OccupiedPiece = new Piece(PieceType.Knight, PieceColor.Black, new KnightMoveRule());
            _board.Cells[7, 7].OccupiedPiece = new Piece(PieceType.Rook, PieceColor.Black, new RookMoveRule());

            // Black pawns
            for (int x = 0; x < Board.Size; x++)
            {
                _board.Cells[x, 6].OccupiedPiece = new Piece(PieceType.Pawn, PieceColor.Black, new PawnMoveRule());
            }

            _currentTurn = PieceColor.White;
        }

        /// <summary>
        /// Parse and apply a single move in algebraic notation
        /// </summary>
        /// <param name="move">Single move like "d4", "Nc3", "Bxe5", etc.</param>
        private void ParseAndApplyMove(string move)
        {
            // Handle special cases
            if (move == "O-O" || move == "O-O-O")
            {
                HandleCastling(move);
                return;
            }

            // Remove check/checkmate indicators
            move = move.Replace("+", "").Replace("#", "");

            PieceType pieceType = PieceType.Pawn;
            bool isCapture = move.Contains("x");
            string fromSquare = "";
            string toSquare = "";

            // Remove 'x' for capture
            move = move.Replace("x", "");

            // Determine piece type
            if (char.IsUpper(move[0]))
            {
                switch (move[0])
                {
                    case 'R': pieceType = PieceType.Rook; break;
                    case 'N': pieceType = PieceType.Knight; break;
                    case 'B': pieceType = PieceType.Bishop; break;
                    case 'Q': pieceType = PieceType.Queen; break;
                    case 'K': pieceType = PieceType.King; break;
                }
                move = move.Substring(1); // Remove piece indicator
            }

            // Parse destination square
            if (move.Length >= 2)
            {
                toSquare = move.Substring(move.Length - 2);
                if (move.Length > 2)
                {
                    fromSquare = move.Substring(0, move.Length - 2);
                }
            }

            // Convert to board coordinates
            var toCoords = AlgebraicToCoordinates(toSquare);
            
            // Find the piece to move
            Cell fromCell = FindPieceToMove(pieceType, fromSquare, toCoords, isCapture);
            Cell toCell = _board.GetCell(toCoords.x, toCoords.y);

            if (fromCell != null && toCell != null)
            {
                // Apply move
                toCell.OccupiedPiece = fromCell.OccupiedPiece;
                fromCell.OccupiedPiece = null;
            }
        }

        /// <summary>
        /// Convert algebraic notation (e.g., "d4") to board coordinates
        /// </summary>
        /// <param name="algebraic">Algebraic square notation like "d4"</param>
        /// <returns>Coordinates (x, y) where (0,0) is bottom-left</returns>
        private (int x, int y) AlgebraicToCoordinates(string algebraic)
        {
            if (algebraic.Length != 2) return (-1, -1);
            
            int x = algebraic[0] - 'a'; // a-h -> 0-7
            int y = algebraic[1] - '1'; // 1-8 -> 0-7
            
            return (x, y);
        }

        /// <summary>
        /// Find the piece that should move to the target square
        /// </summary>
        private Cell FindPieceToMove(PieceType pieceType, string fromHint, (int x, int y) toCoords, bool isCapture)
        {
            List<Cell> candidates = new List<Cell>();

            // Find all pieces of the specified type and color
            for (int x = 0; x < Board.Size; x++)
            {
                for (int y = 0; y < Board.Size; y++)
                {
                    Cell cell = _board.GetCell(x, y);
                    if (cell?.OccupiedPiece != null && 
                        cell.OccupiedPiece.Type == pieceType && 
                        cell.OccupiedPiece.Color == _currentTurn)
                    {
                        // Check if this piece can move to target square
                        if (CanPieceMoveTo(cell, toCoords))
                        {
                            candidates.Add(cell);
                        }
                    }
                }
            }

            // If we have a disambiguation hint (like "Nbd7" where 'b' specifies the file)
            if (!string.IsNullOrEmpty(fromHint) && candidates.Count > 1)
            {
                // Filter by file or rank
                if (fromHint.Length == 1)
                {
                    if (char.IsLetter(fromHint[0]))
                    {
                        // File hint (a-h)
                        int fileIndex = fromHint[0] - 'a';
                        candidates = candidates.FindAll(c => c.X == fileIndex);
                    }
                    else if (char.IsDigit(fromHint[0]))
                    {
                        // Rank hint (1-8)
                        int rankIndex = fromHint[0] - '1';
                        candidates = candidates.FindAll(c => c.Y == rankIndex);
                    }
                }
            }

            return candidates.Count > 0 ? candidates[0] : null;
        }

        /// <summary>
        /// Check if a piece can move to target coordinates (simplified logic)
        /// </summary>
        private bool CanPieceMoveTo(Cell fromCell, (int x, int y) toCoords)
        {
            // Simplified movement validation - in a full implementation,
            // this would use the piece's move rules and check for obstacles
            Cell toCell = _board.GetCell(toCoords.x, toCoords.y);
            if (toCell == null) return false;

            // Can't capture own piece
            if (toCell.OccupiedPiece != null && toCell.OccupiedPiece.Color == _currentTurn)
                return false;

            // Basic piece movement patterns (simplified)
            PieceType pieceType = fromCell.OccupiedPiece.Type;
            int deltaX = toCoords.x - fromCell.X;
            int deltaY = toCoords.y - fromCell.Y;

            switch (pieceType)
            {
                case PieceType.Pawn:
                    return IsValidPawnMove(fromCell, deltaX, deltaY, toCell.OccupiedPiece != null);
                case PieceType.Rook:
                    return (deltaX == 0 || deltaY == 0) && IsPathClear(fromCell, toCell);
                case PieceType.Bishop:
                    return Mathf.Abs(deltaX) == Mathf.Abs(deltaY) && IsPathClear(fromCell, toCell);
                case PieceType.Queen:
                    return ((deltaX == 0 || deltaY == 0) || (Mathf.Abs(deltaX) == Mathf.Abs(deltaY))) && IsPathClear(fromCell, toCell);
                case PieceType.King:
                    return Mathf.Abs(deltaX) <= 1 && Mathf.Abs(deltaY) <= 1;
                case PieceType.Knight:
                    return (Mathf.Abs(deltaX) == 2 && Mathf.Abs(deltaY) == 1) || (Mathf.Abs(deltaX) == 1 && Mathf.Abs(deltaY) == 2);
                default:
                    return false;
            }
        }

        /// <summary>
        /// Validate pawn movement
        /// </summary>
        private bool IsValidPawnMove(Cell fromCell, int deltaX, int deltaY, bool isCapture)
        {
            PieceColor color = fromCell.OccupiedPiece.Color;
            int direction = color == PieceColor.White ? 1 : -1;

            if (isCapture)
            {
                // Diagonal capture
                return Mathf.Abs(deltaX) == 1 && deltaY == direction;
            }
            else
            {
                // Forward movement
                if (deltaX != 0) return false;
                
                // One square forward
                if (deltaY == direction) return true;
                
                // Two squares forward from starting position
                int startingRank = color == PieceColor.White ? 1 : 6;
                return fromCell.Y == startingRank && deltaY == 2 * direction;
            }
        }

        /// <summary>
        /// Check if path between two cells is clear (simplified)
        /// </summary>
        private bool IsPathClear(Cell from, Cell to)
        {
            int deltaX = to.X - from.X;
            int deltaY = to.Y - from.Y;
            int steps = Mathf.Max(Mathf.Abs(deltaX), Mathf.Abs(deltaY));
            
            if (steps <= 1) return true;

            int stepX = deltaX == 0 ? 0 : deltaX / Mathf.Abs(deltaX);
            int stepY = deltaY == 0 ? 0 : deltaY / Mathf.Abs(deltaY);

            for (int i = 1; i < steps; i++)
            {
                int checkX = from.X + i * stepX;
                int checkY = from.Y + i * stepY;
                Cell checkCell = _board.GetCell(checkX, checkY);
                if (checkCell?.OccupiedPiece != null)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Handle castling moves
        /// </summary>
        private void HandleCastling(string move)
        {
            int y = _currentTurn == PieceColor.White ? 0 : 7;
            
            if (move == "O-O") // King-side castling
            {
                // Move king
                Cell kingFrom = _board.GetCell(4, y);
                Cell kingTo = _board.GetCell(6, y);
                kingTo.OccupiedPiece = kingFrom.OccupiedPiece;
                kingFrom.OccupiedPiece = null;

                // Move rook
                Cell rookFrom = _board.GetCell(7, y);
                Cell rookTo = _board.GetCell(5, y);
                rookTo.OccupiedPiece = rookFrom.OccupiedPiece;
                rookFrom.OccupiedPiece = null;
            }
            else if (move == "O-O-O") // Queen-side castling
            {
                // Move king
                Cell kingFrom = _board.GetCell(4, y);
                Cell kingTo = _board.GetCell(2, y);
                kingTo.OccupiedPiece = kingFrom.OccupiedPiece;
                kingFrom.OccupiedPiece = null;

                // Move rook
                Cell rookFrom = _board.GetCell(0, y);
                Cell rookTo = _board.GetCell(3, y);
                rookTo.OccupiedPiece = rookFrom.OccupiedPiece;
                rookFrom.OccupiedPiece = null;
            }
        }

        /// <summary>
        /// Switch the current turn
        /// </summary>
        private void SwitchTurn()
        {
            _currentTurn = _currentTurn == PieceColor.White ? PieceColor.Black : PieceColor.White;
        }
    }
}