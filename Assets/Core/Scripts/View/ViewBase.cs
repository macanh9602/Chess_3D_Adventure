using UnityEngine;

namespace ChessMaster.Core
{
    public abstract class ViewBase : MonoBehaviour
    {
        //===================================================
        #region [Properties]
        protected MeshRenderer _meshRenderer;
        public MeshRenderer MeshRenderer => _meshRenderer ??= GetComponent<MeshRenderer>();

        protected MeshFilter _meshFilter;
        public MeshFilter MeshFilter => _meshFilter ??= GetComponent<MeshFilter>();

        private Material _originalMaterial;
        private Material _currentMaterial;
        #endregion
        //===================================================

        protected virtual void Awake()
        {
            if (MeshRenderer != null)
            {
                _originalMaterial = MeshRenderer.material;
                _currentMaterial = _originalMaterial;
            }
        }

        public virtual void ChangeColor(Color color)
        {
            if (MeshRenderer == null) return;

            // Dispose previous material if it's not the original one
            if (_currentMaterial != _originalMaterial && _currentMaterial != null)
            {
                DestroyImmediate(_currentMaterial);
            }

            // Create new material with new color
            _currentMaterial = new Material(_originalMaterial)
            {
                color = color
            };
            MeshRenderer.material = _currentMaterial;
        }

        public virtual void ResetColor()
        {
            if (MeshRenderer == null) return;

            // Dispose current material if it's not original
            if (_currentMaterial != _originalMaterial && _currentMaterial != null)
            {
                DestroyImmediate(_currentMaterial);
            }

            _currentMaterial = _originalMaterial;
            MeshRenderer.material = _originalMaterial;
        }

        public virtual void SetUpPosition(Vector3 position, Transform parent)
        {
            //MeshFilter.sharedMesh.RecalculateBounds();
            transform.parent = parent;
            transform.localPosition = position;
            transform.localRotation = Quaternion.identity;
            SetupName();
        }

        protected virtual void OnDestroy()
        {
            // Clean up materials on destroy
            if (_currentMaterial != _originalMaterial && _currentMaterial != null)
            {
                DestroyImmediate(_currentMaterial);
            }
        }

        // Abstract method for setting up name - each subclass implements their own naming logic
        protected abstract void SetupName();
    }
}