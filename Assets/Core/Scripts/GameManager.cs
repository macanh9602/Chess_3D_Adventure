using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ChessMaster.Core
{
    public class GameManager
    {
        public Board Board { get; private set; }
        public PieceColor CurrentTurn { get; private set; }

        private MoveValidator _validator;
        private AlgebraicNotationParser _pgnParser;

        public GameManager()
        {
            Board = new Board();
            CurrentTurn = PieceColor.White;

            // Khởi tạo validator (tạm thời chưa check all rule)
            _validator = new MoveValidator(new List<IMoveRule>());
            _pgnParser = new AlgebraicNotationParser(Board);
        }

        public bool TryMove(Cell from, Cell to)
        {
            if (from.OccupiedPiece == null) return false;
            if (from.OccupiedPiece.Color != CurrentTurn) return false;

            if (!from.OccupiedPiece.CanMove(Board, from, to)) return false;

            // TODO: thêm kiểm tra "king in check", castling, v.v.
            to.OccupiedPiece = from.OccupiedPiece;
            from.OccupiedPiece = null;

            SwitchTurn();
            return true;
        }

        private void SwitchTurn()
        {
            CurrentTurn = (CurrentTurn == PieceColor.White) ? PieceColor.Black : PieceColor.White;
        }

        /// <summary>
        /// Generate board from algebraic notation string
        /// Example: "d4 d5 c4 e6 Nc3 Nf6 Bg5 Be7 cxd5 exd5 e3 Bf5"
        /// </summary>
        /// <param name="moveSequence">Space-separated moves in algebraic notation</param>
        public void GenerateBoardFromPGN(string moveSequence)
        {
            _pgnParser.ParseAndApplyMoves(moveSequence);
            // Update current turn based on number of moves
            string[] moves = moveSequence.Trim().Split(' ');
            CurrentTurn = moves.Length % 2 == 0 ? PieceColor.White : PieceColor.Black;
        }

        /// <summary>
        /// Get a visual representation of the current board state
        /// </summary>
        /// <returns>String representation of the board</returns>
        public string GetBoardVisualization()
        {
            string result = "   a b c d e f g h\n";
            
            for (int y = 7; y >= 0; y--) // Print from rank 8 to 1
            {
                result += $"{y + 1}: ";
                for (int x = 0; x < 8; x++)
                {
                    Piece piece = Board.Cells[x, y].OccupiedPiece;
                    if (piece != null)
                    {
                        string pieceSymbol = GetPieceSymbol(piece);
                        result += pieceSymbol + " ";
                    }
                    else
                    {
                        result += ". ";
                    }
                }
                result += "\n";
            }
            
            return result;
        }

        private string GetPieceSymbol(Piece piece)
        {
            string symbol = "";
            switch (piece.Type)
            {
                case PieceType.Pawn: symbol = "P"; break;
                case PieceType.Rook: symbol = "R"; break;
                case PieceType.Knight: symbol = "N"; break;
                case PieceType.Bishop: symbol = "B"; break;
                case PieceType.Queen: symbol = "Q"; break;
                case PieceType.King: symbol = "K"; break;
            }
            
            return piece.Color == PieceColor.White ? symbol : symbol.ToLower();
        }
    }

    public class MoveValidator
    {
        private readonly List<IMoveRule> _rules;

        public MoveValidator(List<IMoveRule> rules)
        {
            _rules = rules;
        }

        public bool IsValid(Board board, Cell from, Cell to)
        {
            foreach (var rule in _rules)
            {
                if (!rule.IsMoveValid(board, from, to)) return false;
            }
            return true;
        }
    }
}
