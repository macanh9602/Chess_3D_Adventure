using DG.Tweening;
using DP.Utilities;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VTLTools.Effect
{
    public class Effect : MonoBehaviour
    {
        [SerializeField] MainParticleSystem mainParticleSystem;
        [SerializeField] bool isDestroyAfterStop = true;

        [ShowInInspector]
        public bool IsPlaying
        {
            get
            {
                if (mainParticleSystem != null)
                    return mainParticleSystem.ThisParticleSystem.isPlaying;
                else
                    return false;
            }
        }
        public void OnParticleSystemStoppedListener()
        {
            if (isDestroyAfterStop)
                Destroy(this.gameObject);
        }

        public void Init(Vector3 _pos, Transform _parent = null)
        {
            this.transform.position = _pos;
            this.transform.parent = _parent;
        }

        public void DOMoveY(float _value, float _duration)
        {
            this.transform.DOMoveY(_value, _duration);
        }

        public void Play()
        {
            if (IsPlaying)
                return;
            DPDebug.Log($"<color=green>Play effect</color>");
            mainParticleSystem.ThisParticleSystem.Play();
        }

        public void Stop()
        {
            mainParticleSystem.ThisParticleSystem.Stop();
        }

        public void Pause()
        {
            mainParticleSystem.ThisParticleSystem.Pause();
        }

        public void SetRateOverTime(float _value)
        {
            var emission = mainParticleSystem.ThisParticleSystem.emission;
            emission.rateOverTime = _value;
        }
    }
}