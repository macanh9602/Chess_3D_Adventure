using DP.Utilities;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace VTLTools
{
    public static class DeviceInfo
    {
        public static string DeviceModel { get; private set; }
        public static int Ram { get; private set; }
        public static bool IsNoAOADevice { get; private set; }
        static readonly List<string> NoAOADevices = new()
        {
            "Realme realme C11"
            ,"Tecno TECNO"
            ,"Tecno TECNO SPARK Go 2024"
            ,"Infinix SMART 8"
            ,"vivo 1904"
            ,"Vivo vivo 1904"
            ,"Vivo vivo 1906"
            ,"vivo 1906"
            ,"Motorola moto e(7)"
            ,"Motorola Lenovo K12"
            ,"Motorola moto e(7) power"
            ,"Motorola moto g(9)"
            ,"Motorola moto g(9) play"
            ,"Vivo V2026"
            ,"Vivo V2026_21"
            ,"Vivo V2042"
            ,"Vivo vivo 1907"
            ,"Redmi Note 9"
            ,"Redmi 9A"
            ,"Redmi 10A"
            ,"Redmi 10A Sport"
            ,"Vivo V2120"
            ,"Vivo V2118"
            ,"Vivo V2125"
            ,"Vivo V2134"
            ,"Samsung Galaxy A10"
            ,"Motorola moto e13"
            ,"RMX3231"
            ,"RMX2185"
            ,"RMX2186"
            ,"TECNO-BG6"
            ,"TECNO-KL4"
            ,"TECNO-BF7"
            ,"TECNO-BF6"
            ,"X6525"
            ,"X6525D"
            ,"X6526"
            ,"vivo 1904"
            ,"vivo 1906"
            ,"motorola malta"
            ,"motorola guam"
            ,"motorola maltalsc"
            ,"Lenovo cebu"
            ,"motorola guamp"
            ,"motorola odessa"
            ,"vivo 2026"
            ,"V2026"
            ,"V2026_21"
            ,"vivo 1907"
            ,"vivo 1907N"
            ,"merlin"
            ,"merlinnfc"
            ,"cannong"
            ,"M2006C3LG"
            ,"220233L2G"
            ,"220233L2I"
            ,"moto e13"
            ,"V2134"
            ,"V2118"
            ,"V2120"
            ,"SM-A105F"
            ,"SM-A105FN"
            ,"moto e(7)"
            ,"Lenovo K12"
            ,"(ASUS)"
        };

        static void GetDeviceInfo()
        {
            DeviceModel = SystemInfo.deviceModel;
            Ram = SystemInfo.systemMemorySize;
            IsNoAOADevice = ContainsAny(DeviceModel, NoAOADevices);
            DPDebug.Log($"Device Model: {DeviceModel}, RAM: {Ram}, IsNoAOADevice: {IsNoAOADevice}");
        }

        public static bool IsWeakDevice()
        {
            GetDeviceInfo();
#if UNITY_ANDROID
            return (Ram < 4096 && IsNoAOADevice || Ram < 3072);
#else
            return Ram < 2048;
#endif
        }

        static bool ContainsAny(string stringToCompare, IEnumerable<string> listToCompareWith)
        {
            return listToCompareWith.Any(stringToCompare.Contains);
        }
    }
}