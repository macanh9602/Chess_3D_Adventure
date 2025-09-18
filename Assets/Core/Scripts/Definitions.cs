using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ChessMaster.Core
{
    public enum PieceType
    {
        None,
        Pawn,
        Knight,
        Bishop,
        Rook,
        Queen,
        King
    }//

    public enum PieceColor
    {
        White,
        Black
    }

    public enum GameState
    {
        Ongoing,
        Check,
        Checkmate,
        Stalemate,
        Draw
    }

    public class Piece
    {
        public PieceType Type;
        public PieceColor Color;

        private IMoveRule moveRule;

        public Piece(PieceType type, PieceColor color, IMoveRule moveRule)
        {
            Type = type;
            Color = color;
            this.moveRule = moveRule;
        }

        public bool CanMove(Board board, Cell from, Cell to)
        {
            return moveRule.IsMoveValid(board, from, to);
        }
    }

    public class Cell
    {
        public int X;
        public int Y;
        public Piece OccupiedPiece;
    }
}