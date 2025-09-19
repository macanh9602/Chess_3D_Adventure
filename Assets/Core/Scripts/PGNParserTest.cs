using System;
using UnityEngine;

namespace ChessMaster.Core
{
    /// <summary>
    /// Simple test class to validate PGN parsing functionality
    /// </summary>
    public class PGNParserTest : MonoBehaviour
    {
        [SerializeField] private string testMoveSequence = "d4 d5 c4 e6 Nc3 Nf6 Bg5 Be7 cxd5 exd5 e3 Bf5 Bd3 Bxd3 Qxd3 c6 Nge2 Nbd7 f3 O-O h4 h6 Bf4 Re8 g4 Nf8 g5 hxg5 hxg5 N6h7 O-O-O Bxg5 Rdg1 Bxf4 Nxf4 Qe7 Kd2 Nf6 Rg2 g6 Nxg6 Nxg6 f4 Ne4+ Nxe4 dxe4 Qe2 Qb4+ Kc2 Qb5 Qg4 Qd3+ Kc1 Qxe3+ Kb1 Qd3+ Ka1 Qxd4";

        void Start()
        {
            TestPGNParser();
        }

        public void TestPGNParser()
        {
            Debug.Log("Starting PGN Parser Test...");

            try
            {
                GameManager gameManager = new GameManager();
                
                Debug.Log($"Testing with move sequence: {testMoveSequence.Substring(0, Math.Min(50, testMoveSequence.Length))}...");
                
                // Generate board from PGN
                gameManager.GenerateBoardFromPGN(testMoveSequence);
                
                // Print board state
                PrintBoardState(gameManager.Board);
                
                Debug.Log("PGN Parser Test completed successfully!");
            }
            catch (Exception e)
            {
                Debug.LogError($"PGN Parser Test failed: {e.Message}");
                Debug.LogError($"Stack trace: {e.StackTrace}");
            }
        }

        private void PrintBoardState(Board board)
        {
            Debug.Log("Current board state:");
            
            for (int y = 7; y >= 0; y--) // Print from rank 8 to 1
            {
                string rank = $"{y + 1}: ";
                for (int x = 0; x < 8; x++)
                {
                    Piece piece = board.Cells[x, y].OccupiedPiece;
                    if (piece != null)
                    {
                        string pieceSymbol = GetPieceSymbol(piece);
                        rank += pieceSymbol + " ";
                    }
                    else
                    {
                        rank += ". ";
                    }
                }
                Debug.Log(rank);
            }
            
            // Print files
            Debug.Log("   a b c d e f g h");
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
}