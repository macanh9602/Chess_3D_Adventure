using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DP.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace MDATools.UI
{
    public abstract class BaseItemButton<T> : MonoBehaviour
    {
        [SerializeField] protected Button button;
        [SerializeField] protected Image icon;
        [SerializeField] protected Image adsIcon;
        [SerializeField] protected DOTweenAnimation shakeAnimation;

        protected T itemType;

        protected virtual void Start()
        {
            button.onClick.AddListener(OnClick);
        }

        public virtual void Init(T type, Sprite sprite)
        {
            itemType = type;
            icon.sprite = sprite;
            UpdateUI();
        }

        public virtual void UpdateUI()
        {
            bool isUnlocked = IsUnlocked();

            adsIcon.gameObject.SetActive(!isUnlocked);
            if (isUnlocked)
            {
                shakeAnimation.DOKill();
                adsIcon.transform.rotation = Quaternion.identity;
            }
            else
            {
                shakeAnimation.DOPlay();
            }
        }

        protected virtual void OnClick()
        {
            DPDebug.Log($"Clicked on item: {itemType}");
            if (IsUnlocked())
            {
                OnSelect(itemType);
            }
            else
            {
                ShowAds(() =>
                {
                    Unlock();
                    UpdateUI();
                });
            }
        }

        protected abstract bool IsUnlocked();
        protected abstract void Unlock();
        protected abstract void OnSelect(T itemType);
        protected abstract void ShowAds(System.Action onComplete);
    }

}
