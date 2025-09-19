using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChessMaster.Core
{
    public class PieceView : ViewBase
    {
        public Piece Piece { get; private set; }

        public void Init(Piece piece)
        {
            Piece = piece;
            UpdateSprite();
            SetupName();
        }

        private void UpdateSprite()
        {
            // TODO: gán sprite theo Piece.Type + Piece.Color
            // tạm thời đổi màu để test
            var color = (Piece.Color == PieceColor.White) ? Color.white : Color.black;
            ChangeColor(color);
        }

        public override void ChangeColor(Color color)
        {
            //base.ChangeColor(color);
            // có thể thêm hiệu ứng sáng lên khi chọn
            var theme = ListThemeConfig.GetThemeConfig(ThemeType.Default);
            Material mat = (Piece.Color == PieceColor.White) ? theme.whiteMat : theme.blackMat;
            MeshRenderer.material = mat;
        }

        public override void SetUpPosition(Vector3 origin, Transform parent)
        {
            base.SetUpPosition(origin, parent);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        protected override void SetupName()
        {
            if (Piece != null)
            {
                name = $"Piece_{Piece.Type}_{Piece.Color}";
            }
        }
    }
}
