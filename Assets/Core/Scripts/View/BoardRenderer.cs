using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTLTools;

namespace ChessMaster.Core
{
    public class BoardRenderer : MonoBehaviour
    {
        [SerializeField] Transform boardParent;
        public CellView CellPrefab;
        public PieceView PiecePrefab;
        public float CellSize = 1f;
        
        [Header("PGN Testing")]
        [SerializeField] private bool usePGN = false;
        [SerializeField] [TextArea(3, 10)] private string pgnMoves = "d4 d5 c4 e6 Nc3 Nf6 Bg5 Be7 cxd5 exd5 e3 Bf5 Bd3 Bxd3 Qxd3 c6";

        private GameManager _gameManager;
        private CellView[,] _cellViews;
        private PieceView[,] _pieceViews;

        private Cell _selectedCell;

        void Start()
        {
            _gameManager = new GameManager();
            _cellViews = new CellView[Board.Size, Board.Size];
            _pieceViews = new PieceView[Board.Size, Board.Size];

            RenderBoard();
            
            if (usePGN && !string.IsNullOrEmpty(pgnMoves))
            {
                PlacePiecesFromPGN();
            }
            else
            {
                PlacePiecesTest(); // tạm thời set quân test
            }
        }

        private void RenderBoard()
        {
            Vector3 startPoint = new Vector3(-Board.Size / 2f, -Board.Size / 2f, 0);

            for (int x = 0; x < Board.Size; x++)
            {
                for (int y = 0; y < Board.Size; y++)
                {
                    var cellView = Instantiate(CellPrefab);

                    cellView.Init(x, y, this);
                    cellView.SetUpPosition(startPoint + new Vector3(x * CellSize, y * CellSize, 0), boardParent);
                    _cellViews[x, y] = cellView;
                }
            }
        }

        private void PlacePiecesTest()
        {
            // Test: đặt vài quân tượng trưng
            var board = _gameManager.Board;

            board.Cells[0, 1].OccupiedPiece = new Piece(PieceType.Pawn, PieceColor.White, null);
            board.Cells[0, 6].OccupiedPiece = new Piece(PieceType.Pawn, PieceColor.Black, null);

            SpawnPiece(board.Cells[0, 1]);
            SpawnPiece(board.Cells[0, 6]);
        }

        private void PlacePiecesFromPGN()
        {
            Debug.Log($"Generating board from PGN: {pgnMoves.Substring(0, Mathf.Min(50, pgnMoves.Length))}...");
            
            try
            {
                // Generate board from PGN notation
                _gameManager.GenerateBoardFromPGN(pgnMoves);
                
                // Spawn visual pieces for all occupied cells
                for (int x = 0; x < Board.Size; x++)
                {
                    for (int y = 0; y < Board.Size; y++)
                    {
                        Cell cell = _gameManager.Board.Cells[x, y];
                        if (cell.OccupiedPiece != null)
                        {
                            SpawnPiece(cell);
                        }
                    }
                }
                
                Debug.Log("Board generated successfully from PGN!");
            }
            catch (System.Exception e)
            {
                Debug.LogError($"Failed to generate board from PGN: {e.Message}");
                Debug.LogError($"Stack trace: {e.StackTrace}");
                // Fall back to test pieces
                PlacePiecesTest();
            }
        }

        private void SpawnPiece(Cell cell)
        {
            Vector3 startPoint = new Vector3(-Board.Size / 2f, -Board.Size / 2f, 0);
            var pieceView = Instantiate(PiecePrefab);
            pieceView.Init(cell.OccupiedPiece);
            pieceView.SetUpPosition(startPoint + new Vector3(cell.X * CellSize, cell.Y * CellSize, -1), boardParent);
            _pieceViews[cell.X, cell.Y] = pieceView;
        }

        public void OnCellClicked(int x, int y)
        {
            var cell = _gameManager.Board.Cells[x, y];

            if (_selectedCell == null)
            {
                if (cell.OccupiedPiece != null)
                {
                    _selectedCell = cell;
                    Debug.Log($"Selected piece at {x},{y}");
                }
            }
            else
            {
                if (_gameManager.TryMove(_selectedCell, cell))
                {
                    MovePieceView(_selectedCell, cell);
                    Debug.Log($"Moved to {x},{y}");
                }
                _selectedCell = null;
            }
        }

        private void MovePieceView(Cell from, Cell to)
        {
            var pieceView = _pieceViews[from.X, from.Y];
            _pieceViews[from.X, from.Y] = null;

            if (_pieceViews[to.X, to.Y] != null)
            {
                Destroy(_pieceViews[to.X, to.Y].gameObject); // ăn quân
            }

            pieceView.transform.position = new Vector3(to.X * CellSize, to.Y * CellSize, -0.5f);
            _pieceViews[to.X, to.Y] = pieceView;
        }
    }

}
