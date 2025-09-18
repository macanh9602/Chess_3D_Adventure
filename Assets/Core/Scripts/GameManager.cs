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

        public GameManager()
        {
            Board = new Board();
            CurrentTurn = PieceColor.White;

            // Khởi tạo validator (tạm thời chưa check all rule)
            _validator = new MoveValidator(new List<IMoveRule>());
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
