using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChessMaster.Core
{
    public class CellView : ViewBase
    {
        public int X;
        public int Y;
        private BoardRenderer _boardRenderer;

        public void Init(int x, int y, BoardRenderer boardRenderer)
        {
            X = x;
            Y = y;
            _boardRenderer = boardRenderer;
            SetupName();
            ChangeColor(((x + y) % 2 == 0) ? Color.gray : Color.white);
        }

        private void OnMouseDown()
        {
            _boardRenderer.OnCellClicked(X, Y);
        }

        public override void SetUpPosition(Vector3 origin, Transform parent)
        {
            base.SetUpPosition(origin, parent);
            SetupName();
        }

        protected override void SetupName()
        {
            gameObject.name = $"Cell_{X}_{Y}";
        }

    }
}
