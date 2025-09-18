using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace VTLTools
{
    public class BackGroundScaleFit : MonoBehaviour
    {
        RectTransform rectTransform;
        [ShowInInspector]
        RectTransform ThisRectTransform => rectTransform = rectTransform != null ? rectTransform : GetComponent<RectTransform>();


        [SerializeField, ReadOnly] float resolutionX;
        [SerializeField, ReadOnly] float resolutionY;

        [SerializeField, ReadOnly] float ratioX;
        [SerializeField, ReadOnly] float ratioY;

        private void Awake()
        {
            resolutionX = Screen.currentResolution.width;
            resolutionY = Screen.currentResolution.height;
        }

        private void Start()
        {
            ratioX = resolutionX / 720;
            ratioY = resolutionY / 1280;

            if (ratioX > ratioY)
            {

                //bgRectTransform.sizeDelta = bgRectTransform.sizeDelta / (1280 / 720) * (resolutionY / resolutionX);
                float _newX = ThisRectTransform.sizeDelta.x / (720f / 1280f) * (resolutionX / resolutionY);
                float _newY = ThisRectTransform.sizeDelta.y / (720f / 1280f) * (resolutionX / resolutionY);
                ThisRectTransform.sizeDelta = new Vector2(_newX, _newY);
                //loadingSlider.GetComponent<RectTransform>().localScale *= ratioX;
            }
            else
            {
                float _newX = ThisRectTransform.sizeDelta.x / (1280f / 720f) * (resolutionY / resolutionX);
                float _newY = ThisRectTransform.sizeDelta.y / (1280f / 720f) * (resolutionY / resolutionX);
                ThisRectTransform.sizeDelta = new Vector2(_newX, _newY);
                //loadingSlider.GetComponent<RectTransform>().localScale *= ratioY;
            }
        }
    }
}