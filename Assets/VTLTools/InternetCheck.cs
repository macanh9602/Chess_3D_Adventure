using DP.Utilities;
using UnityEngine;
using VTLTools;

public class InternetCheck
{
    public static void CheckInternetConnection()
    {
        NetworkReachability reachability = Application.internetReachability;

        if (reachability == NetworkReachability.NotReachable)
        {
            DPDebug.Log("<color=red>Device is NOT connected to the internet!</color>");
            //show popup not connect internet
        }
        else
        {
            DPDebug.Log("<color=yellow>Device is connected to the internet.</color>");
            //hide popup not connect internet
        }
    }
}
