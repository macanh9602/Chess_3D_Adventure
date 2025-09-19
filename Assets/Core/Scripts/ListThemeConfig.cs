using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChessMaster.Core
{

    [CreateAssetMenu(fileName = "ListThemeConfig", menuName = "ScriptableObjects/Category/ListThemeConfig", order = 2)]
    public class ListThemeConfig : ScriptableObject
    {
        #region Fields
        private const string ITEM_RESOURCE_FOLDER_PATH = "Data/ListThemeConfig";

        private static ResourceAsset<ListThemeConfig> asset = new(ITEM_RESOURCE_FOLDER_PATH);

        [SerializeField] List<ThemeConfig> lstConfigs = new();
        #endregion

        #region Properties

        #endregion

        #region Lifecycle

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        public static ThemeConfig GetThemeConfig(ThemeType type)
        {
            return asset.Value.lstConfigs.Find(config => config.type == type);
        }

        public static PieceView GetPiecePrefab(ThemeType themeType, PieceType pieceType)
        {
            var themeConfig = GetThemeConfig(themeType);
            if (themeConfig == null) return null;
            var pieceConfig = themeConfig.pieceConfigs.Find(config => config.type == pieceType);
            return pieceConfig?.prefab;
        }
        #endregion
    }
}
