// using Sirenix.OdinInspector;
// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using VTLTools;

// public class PushRateTracking : Singleton<PushRateTracking>
// {
//     //[ShowInInspector]
//     //int IndexShowPush
//     //{
//     //    get
//     //    {
//     //        if (CC_Interface.current != null)
//     //            return CC_Interface.current.indexShowPush;
//     //        else
//     //            return 0;
//     //    }
//     //}
//     //[ShowInInspector]
//     //int IndexStartShowPush
//     //{
//     //    get
//     //    {
//     //        if (CC_Interface.current != null)
//     //            return CC_Interface.current.levelStartShowPush;
//     //        else
//     //            return 0;
//     //    }
//     //}
//     [ShowInInspector]
//     int IndexShowRate
//     {
//         get
//         {
//             if (CC_Interface.current != null)
//                 return CC_Interface.current.indexShowRate;
//             else
//                 return 6;
//         }
//     }
//     [ShowInInspector]
//     int IndexStartShowRate
//     {
//         get
//         {
//             if (CC_Interface.current != null)
//                 return CC_Interface.current.Rate_levelStartShow;
//             else
//                 return 20;
//         }
//     }

//     [ShowInInspector]
//     //int IOS_Rate_levelStartShow_review
//     //{
//     //    get
//     //    {
//     //        if (CC_Interface.current != null)
//     //            return CC_Interface.current.iOS_Rate_levelStartShow_review;
//     //        else
//     //            return 999;
//     //    }
//     //}


//     [SerializeField, ReadOnly] bool isGoodToShowPush;
//     [SerializeField, ReadOnly] bool isGoodToShowRate;
//     //[SerializeField, ReadOnly] bool isGoodToShowRateReview;



//     public void CheckShowPushRate(float _delayShow, Action _onCompleteShowAction)
//     {
//         StartCoroutine(_DelayShowPopup());

//         IEnumerator _DelayShowPopup()
//         {
//             yield return new WaitForSeconds(_delayShow);
//             _ShowPopup();
//         }
//         void _ShowPopup()
//         {
//             //isGoodToShowPush = _IsGoodToShowPush();
//             isGoodToShowRate = _IsGoodToShowRate();
//             //isGoodToShowRateReview = _IsGoodToShowRateReview();
//             //Debug.Log(isGoodToShowRate.ToString() + isGoodToShowRateReview.ToString());
//             /*
//             if (isGoodToShowPush && isGoodToShowRate)
//             {
//                 UIManager.Instance.pushPopup.Show(null, 0, true, null, null, null,
//                 () =>
//                 {
//                     UIManager.Instance.ratePopup.Show(false, 0, true, null, null, null,
//                     () =>
//                     {
//                         _onCompleteShowAction?.Invoke();
//                     });
//                 });
//                 return;
//             }

//             if (isGoodToShowPush)
//             {
//                 UIManager.Instance.pushPopup.Show(null, 0, true, null, null, null,
//                 () =>
//                 {
//                     _onCompleteShowAction?.Invoke();
//                 });
//                 return;
//             }
//             if (isGoodToShowRate)
//             {
//                 UIManager.Instance.ratePopup.Show(false, 0, true, null, null, null,
//                 () =>
//                 {
//                     _onCompleteShowAction?.Invoke();
//                 });
//                 return;
//             }

//             if (!isGoodToShowPush && !isGoodToShowRate)
//             {

//                 _onCompleteShowAction?.Invoke();
//                 return;
//             }        */

//             //if (isGoodToShowRate && isGoodToShowRateReview)
//             //{
//             //    Debug.Log(isGoodToShowRate.ToString() + isGoodToShowRateReview.ToString());
//             //    UIManager.Instance.ratePopup.Show(true, 0, true, null, null, null,
//             //    () =>
//             //    {
//             //        _onCompleteShowAction?.Invoke();
//             //    });
//             //    return;
//             //}

//             //if (isGoodToShowRateReview)
//             //{
//             //    Debug.Log(isGoodToShowRate.ToString() + isGoodToShowRateReview.ToString());
//             //    UIManager.Instance.ratePopup.Show(true, 0, true, null, null, null,
//             //    () =>
//             //    {
//             //        _onCompleteShowAction?.Invoke();
//             //    });
//             //    return;
//             //}
//             // isGoodToShowRate = true;
//             if (isGoodToShowRate)
//             {
//                 //Debug.Log(isGoodToShowRate.ToString() + isGoodToShowRateReview.ToString());
//                 UIManager.Instance.ratePopup.Show(false, 0, true, null, null, null,
//                 () =>
//                 {
//                     _onCompleteShowAction?.Invoke();
//                 });
//                 return;
//             }
//             else
//             {
//                 _onCompleteShowAction?.Invoke();
//             }

//             //if (!isGoodToShowRateReview && !isGoodToShowRate)
//             //{
//             //    Debug.Log(isGoodToShowRate.ToString() + isGoodToShowRateReview.ToString());
//             //    _onCompleteShowAction?.Invoke();
//             //    return;
//             //}
//         }

//         /*
//         //bool _IsGoodToShowPush()
//         //{
//         //    if (CC_PushMoreGames.current.IsAlreadyDownloadedPushGame())
//         //        return false;

//         //    if (StaticVariables.CurrentRunLevel == IndexStartShowPush)
//         //    {
//         //        if (!StaticVariables.IsShowPushAtLeastOne)
//         //        {
//         //            //Good to show push;
//         //            StaticVariables.CurrentIndexShowPush = IndexShowPush;
//         //            StaticVariables.IsShowPushAtLeastOne = true;
//         //            return true;
//         //        }
//         //        else
//         //        {
//         //            StaticVariables.CurrentIndexShowPush--;
//         //            return false;
//         //        }
//         //    }
//         //    else
//         //    {
//         //        StaticVariables.CurrentIndexShowPush--;
//         //        if (StaticVariables.CurrentIndexShowPush == 0)
//         //        {
//         //            //Good to show push;
//         //            StaticVariables.CurrentIndexShowPush = IndexShowPush;
//         //            return true;
//         //        }
//         //        else
//         //        {
//         //            //Not good to show push
//         //            return false;
//         //        }
//         //    }
//         //}*/

//         bool _IsGoodToShowRate()
//         {
//             if (StaticVariables.IsRated)
//                 return false;

//             if (!StaticVariables.IsShowRateAtLeastOne)
//             {
//                 if (StaticVariables.CountGamePlayed >= IndexStartShowRate)
//                 {
//                     //Good to show rate;

//                     StaticVariables.CurrentIndexShowRate = IndexShowRate;
//                     StaticVariables.CurrentIndexShowRateReview = IndexShowRate;
//                     StaticVariables.IsShowRateAtLeastOne = true;
//                     return true;
//                 }
//                 else
//                     return false;
//             }
//             else
//             {
//                 if (StaticVariables.CurrentIndexShowRate == 0)
//                 {
//                     //Good to show rate;
//                     StaticVariables.CurrentIndexShowRate = IndexShowRate;
//                     return true;
//                 }
//                 else
//                 {
//                     StaticVariables.CurrentIndexShowRate--;
//                     //Not good to show rate
//                     return false;
//                 }
//             }
//         }

//         //        bool _IsGoodToShowRateReview()
//         //        {
//         //#if UNITY_IOS
//         //            if (StaticVariables.IsRated)
//         //                return false;

//         //            if (IOS_Rate_levelStartShow_review == 999)
//         //                return false;

//         //            if (!StaticVariables.IsShowRateAtLeastOne)
//         //            {
//         //                if (StaticVariables.CountGamePlayed >= IOS_Rate_levelStartShow_review)
//         //                {
//         //                    //Good to show rate;

//         //                    StaticVariables.CurrentIndexShowRate = IndexShowRate;
//         //                    StaticVariables.CurrentIndexShowRateReview = IndexShowRate;
//         //                    StaticVariables.IsShowRateAtLeastOne = true;
//         //                    return true;
//         //                }
//         //                else
//         //                    return false;
//         //            }
//         //            else
//         //            {
//         //                if (StaticVariables.CurrentIndexShowRateReview == 0)
//         //                {
//         //                    //Good to show rate;
//         //                    StaticVariables.CurrentIndexShowRateReview = IndexShowRate;
//         //                    return true;
//         //                }
//         //                else
//         //                {
//         //                    StaticVariables.CurrentIndexShowRateReview--;
//         //                    //Not good to show rate
//         //                    return false;
//         //                }
//         //            }

//         //#else
//         //            return false;
//         //#endif

//         //        }
//     }
// }
