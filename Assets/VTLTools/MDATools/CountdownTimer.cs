using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AntiStress.MiniGame
{
    public class CountdownTimer : MonoBehaviour
    {
        public event Action<float> OnTick;       // tick mỗi frame (thời gian còn lại)
        public event Action OnFinished;          // khi hết giờ
        public event Action OnPaused;
        public event Action OnResumed;

        private Coroutine countDownCoroutine;
        private float currentTime;
        private float pausedTime;
        private bool isCountingDown;

        [SerializeField] private Text timerText;

        public void StartTimer(float time)
        {
            StopTimer();
            isCountingDown = true;
            countDownCoroutine = StartCoroutine(IECountdown(time));
        }

        public void StopTimer()
        {
            if (countDownCoroutine == null) return;
            StopCoroutine(countDownCoroutine);
            countDownCoroutine = null;
            pausedTime = currentTime;
            isCountingDown = false;
            OnPaused?.Invoke();
        }

        public void ResumeTimer()
        {
            if (pausedTime > 0 && !isCountingDown)
            {
                countDownCoroutine = StartCoroutine(IECountdown(pausedTime));
                pausedTime = 0;
                isCountingDown = true;
                OnResumed?.Invoke();
            }
        }

        IEnumerator IECountdown(float time)
        {
            currentTime = time;
            while (currentTime > 0)
            {
                currentTime -= Time.deltaTime;
                OnTick?.Invoke(currentTime);
                timerText.text = Mathf.CeilToInt(currentTime).ToString();
                yield return null;
            }

            isCountingDown = false;
            OnFinished?.Invoke();
        }
    }
}
