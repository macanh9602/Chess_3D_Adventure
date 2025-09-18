using System.Collections.Generic;

public enum EventName
{
    NONE,

    OnBeforeGameStateChange,
    OnAfterGameStateChange,

    OnBeforeJigsawStateChange,
    OnAfterJigsawStateChange,

    OnBeforeMemoryChange,
    OnAfterMemoryChange,

    OnResetGyroGame,

    OnToggleSoundSetting,

    OnUnloadMiniGameScene,

    OnSettingPopupOpened,
    OnChanegCountBoxInBlindBox,
    OnFetchFirebaseSuccess,

    #region BrainrotMerge
    OnSweep,
    #endregion

}

public class EventTypeComparer : IEqualityComparer<EventName>
{
    public bool Equals(EventName x, EventName y)
    {
        return x == y;
    }

    public int GetHashCode(EventName t)
    {
        return (int)t;
    }
}
