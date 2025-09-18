using DP.Utilities;
using I2.Loc;
using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CountDownTime : MonoBehaviour
{
    
    [SerializeField] private Text txtTime;
    [SerializeField] private LocalizationParamsManager paramsManager;
    [SerializeField] private bool onEnable;
    [SerializeField] private bool isEdit;
    [ShowIf("isEdit", true), SerializeField] private CountDownTimeType typeCountDown;
    [ShowIf("isEdit", true), SerializeField] private string textTimeFormat = "{0}D {1}H";
    [ShowIf("isEdit"), SerializeField] private TimeMaxType typeTimeMax;
    [ShowIf("typeCountDown", CountDownTimeType.TimeStacking), SerializeField] private TimeStacking timeStacking;
    [ShowIf("typeCountDown", CountDownTimeType.TimeLimited), SerializeField] private TimeLimited timeLimited;
    [SerializeField] private UnityEvent onComplete;

    public DateTime TimeNow { get { return DateTime.Now; } }
    public DateTime TimeTarget
    {
        get
        {
            return new DateTime(timeLimited.Year,timeLimited.Month,timeLimited.Day, timeLimited.Hour, timeLimited.Minute, timeLimited.Second);
        }
    }
    
    private void OnValidate()
    {
        if (!isEdit)
        {
            typeCountDown = CountDownTimeType.Auto;
        }
        if (typeCountDown == CountDownTimeType.TimeStacking)
        {
            timeStacking.isShowDay = typeTimeMax == TimeMaxType.Day;
            timeStacking.isShowHour = typeTimeMax >= TimeMaxType.Hour;
            timeStacking.isShowMinute = typeTimeMax >= TimeMaxType.Minute;
            timeStacking.isShowSecond = typeTimeMax >= TimeMaxType.Second;
            if (timeStacking.Second / 60 >= 1 && timeStacking.isShowMinute)
            {
                timeStacking.Minute += (int)timeStacking.Second / 60;
                timeStacking.Second = timeStacking.Second % 60;
            }
            if (timeStacking.Minute / 60 >= 1 && timeStacking.isShowHour)
            {
                timeStacking.Hour += (int)timeStacking.Minute / 60;
                timeStacking.Minute = timeStacking.Minute % 60;
            }
            if (timeStacking.Hour / 24 >= 1 && timeStacking.isShowDay)
            {
                timeStacking.Day += (int)timeStacking.Hour / 24;
                timeStacking.Hour = timeStacking.Hour % 24;
            }

        }
        else
        {
            timeStacking.isShowDay = false;
            timeStacking.isShowHour = false;
            timeStacking.isShowMinute = false;
            timeStacking.isShowSecond = false;
        }

    }

    private void OnEnable()
    {
        if(onEnable)
        {
            _Init();
        }
    }

    public void _Init()
    {
        if(typeCountDown == CountDownTimeType.TimeStacking)
        {
            DateTime updatedDateTime = TimeNow;
            updatedDateTime = updatedDateTime.AddSeconds(timeStacking.Second);
            updatedDateTime = updatedDateTime.AddMinutes(timeStacking.Minute);
            updatedDateTime = updatedDateTime.AddHours(timeStacking.Hour);
            updatedDateTime = updatedDateTime.AddDays(timeStacking.Day);
            SetTimeLimited(updatedDateTime);
        }
        gameObject.SetActive(true);
        _OnStarCountDown();
    }

    [ShowIf("isEdit", true), Button]
    public void _OnStarCountDown()
    {
        StartCoroutine(IECountDown());
        IEnumerator IECountDown()
        {
            while(true)
            {
                yield return null;
                if (TimeTarget < TimeNow)
                {
                    DPDebug.Log("Complete");
                    onComplete?.Invoke();
                    gameObject.SetActive(false);
                    paramsManager?.gameObject.SetActive(false);
                    txtTime?.gameObject.SetActive(false);
                    
                    yield break;
                }
                else
                    SetTextTime();
            }
        }
    }

    [ShowIf("typeCountDown", CountDownTimeType.TimeLimited), Button]
    public void SetAutoTimeLimited()
    {
        SetTimeLimited(TimeNow);
    }

    public void SetTimeLimited(DateTime _timeLimited)
    {
        timeLimited.Year = _timeLimited.Year;
        timeLimited.Month = _timeLimited.Month;
        timeLimited.Day = _timeLimited.Day;
        timeLimited.Hour = _timeLimited.Hour;
        timeLimited.Minute = _timeLimited.Minute;
        timeLimited.Second = _timeLimited.Second;
    }
    private void SetTextTime()
    {
        var _time = TimeTarget - TimeNow;
        string _txtTime = typeTimeMax switch
        {
            TimeMaxType.Day => string.Format(textTimeFormat, _time.Days, _time.Hours, _time.Minutes, _time.Seconds),
            TimeMaxType.Hour => string.Format(textTimeFormat, _time.Hours, _time.Minutes, _time.Seconds),
            TimeMaxType.Minute => string.Format(textTimeFormat, _time.Minutes, _time.Seconds),
            TimeMaxType.Second => string.Format(textTimeFormat, _time.Seconds),
            _ => string.Empty
        };
        if(txtTime)
        {
            txtTime.gameObject.SetActive(true);
            txtTime.text = _txtTime;
        }
        if(paramsManager)
        {
            paramsManager.gameObject.SetActive(true);
            paramsManager.SetParameterValue(paramsManager._Params[0].Name, _txtTime);
        }
    }

    #region DEFINE
    [System.Serializable]
    public class TimeStacking
    {
        [HideInInspector] public bool isShowDay, isShowHour, isShowMinute, isShowSecond;

        [ShowIf("isShowDay", true), HorizontalGroup("0", 100), LabelWidth(50), LabelText("Day")] public int Day;
        [ShowIf("isShowHour", true), HorizontalGroup("0", 100), LabelWidth(50), LabelText("Hour")] public int Hour;
        [ShowIf("isShowMinute", true), HorizontalGroup("0", 100), LabelWidth(50), LabelText("Minute")] public int Minute;
        [ShowIf("isShowSecond", true), HorizontalGroup("0", 100), LabelWidth(50), LabelText("Second")] public int Second;
    }
    [System.Serializable]
    public class TimeLimited
    {
        [HorizontalGroup("0", 150), LabelText("DD/MM/YYYY :"), LabelWidth(100)] public int Day;
        [HorizontalGroup("0", 50), LabelText(":"), LabelWidth(5)] public int Month;
        [HorizontalGroup("0", 50), LabelText(":"), LabelWidth(5)] public int Year;
        [Space(10), HorizontalGroup("1", 100), LabelText("Hour :"), LabelWidth(35)] public int Hour;
        [Space(10), HorizontalGroup("1", 100), LabelText("Minute :"), LabelWidth(45)] public int Minute;
        [Space(10), HorizontalGroup("1", 100), LabelText("Second :"), LabelWidth(50)] public int Second;
    }
    public enum CountDownTimeType
    {
        Auto,
        TimeStacking, // khi muốn count down time một khoảng thời gian
        TimeLimited, // khi muốn count down time một mốc thời gian
    }
    public enum TimeMaxType
    {
        None,
        Second,
        Minute,
        Hour,
        Day,
    }
    #endregion
}
