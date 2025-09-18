using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MDATools.UI
{
    public abstract class BaseItemScrollView<T, TButton> : MonoBehaviour
    where TButton : BaseItemButton<T>
    {
        [SerializeField] protected TButton buttonPrefab;
        [SerializeField] protected Transform content;
        protected List<TButton> buttonList = new List<TButton>();

        protected abstract IEnumerable<T> GetItemTypes();
        protected abstract Sprite GetSprite(T type);

        protected virtual void Start()
        {
            Spawn();
        }

        public virtual void Spawn()
        {
            foreach (var type in GetItemTypes())
            {
                var button = Instantiate(buttonPrefab, content);
                button.Init(type, GetSprite(type));
                buttonList.Add(button);
            }
        }

        public virtual void UpdateAllUI()
        {
            foreach (var btn in buttonList)
            {
                btn.UpdateUI();
            }
        }
    }

}
