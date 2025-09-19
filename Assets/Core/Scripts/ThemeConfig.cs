using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ChessMaster.Core
{
    [CreateAssetMenu(fileName = "ThemeConfig", menuName = "ScriptableObjects/ThemeConfig", order = 1)]
    public class ThemeConfig : ScriptableObject
    {
        #region Fields
        [VerticalGroup("0/1"), LabelWidth(100)]
        public ThemeType type;

        [PreviewField(100), HideLabel, HorizontalGroup("0", 100)]
        public Sprite icon;

        [VerticalGroup("0/1"), LabelWidth(100)]
        public List<PieceConfig> pieceConfigs = new();

        public Material blackMat;
        public Material whiteMat;
        #endregion

        #region Properties

        #endregion

        #region Lifecycle

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        #endregion
    }

    public enum ThemeType
    {
        Default = 0,
    }

    [System.Serializable]
    public class PieceConfig
    {
        public PieceType type;
        public PieceView prefab;
    }
}
