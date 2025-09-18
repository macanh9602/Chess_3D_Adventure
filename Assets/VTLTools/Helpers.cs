using System.Collections.Generic;
using UnityEngine;
using DP.Utilities;
using UnityEngine.Networking;
using System.Collections;
using System.IO;
using AntiStress;
using System.Linq;
using UnityEditor;
using DG.Tweening;
using UnityEngine.UI;

namespace VTLTools
{
    /// <summary>
    /// A static class for general helpful methods
    /// </summary> 

    public class Helpers : MonoBehaviour
    {
        public static int Fibonacci(int n)
        {
            if (n <= 0)
                return 1;
            if (n == 1)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int RandomByWeight(float[] probs)
        {

            float total = 0;

            foreach (float elem in probs)
            {
                total += elem;
            }

            float randomPoint = Random.value * total;

            for (int i = 0; i < probs.Length; i++)
            {
                if (randomPoint < probs[i])
                {
                    return i;
                }
                else
                {
                    randomPoint -= probs[i];
                }
            }
            return probs.Length - 1;
        }

        public static void DestroyAllChilds(Transform go)
        {
            for (int i = go.childCount - 1; i >= 0; i--)
            {
                Destroy(go.GetChild(i).gameObject);
            }
        }

        public static void DestroyImmediateAllChilds(Transform go)
        {
            for (int i = go.childCount - 1; i >= 0; i--)
            {
                DestroyImmediate(go.GetChild(i).gameObject);
            }
        }

        public static void RecycleAllChilds(GameObject go)
        {
            for (int i = go.transform.childCount - 1; i >= 0; i--)
            {
                ObjectPool.Recycle(go.transform.GetChild(i).gameObject);
            }
        }

        public static List<T> GetAllChildsComponent<T>(Transform _parent)
        {
            List<T> _l = new();
            foreach (Transform _child in _parent.GetComponentsInChildren<Transform>(true))
            {
                if (_child.GetComponent<T>() != null)
                    _l.Add(_child.GetComponent<T>());
            }
            return _l;
        }

        //get all child with name have string
        public static List<T> GetAllChildsComponentByName<T>(Transform _parent, string _name)
        {
            List<T> _l = new();
            foreach (Transform _child in _parent.GetComponentsInChildren<Transform>(true))
            {
                if (_child.name.Contains(_name) && _child.GetComponent<T>() != null)
                    _l.Add(_child.GetComponent<T>());
            }
            return _l;
        }

        public static void SaveStringToFile(string _filePath, string _textToSave)
        {
            File.WriteAllText("Assets/Resources/" + _filePath + ".txt", _textToSave);
        }

        public static string LoadFileToString(string _filePath)
        {
            TextAsset _textAss = (TextAsset)Resources.Load(_filePath);
            return _textAss.text;
        }

        public static Vector3 WorldToLocalPointInRectangle(Vector3 _worldPosition, Canvas _canvasParent)
        {
            // Convert the world position to screen space
            Vector2 _screenPosition = Camera.main.WorldToScreenPoint(_worldPosition);

            // Convert the screen position to canvas local position
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_canvasParent.transform as RectTransform, _screenPosition, _canvasParent.worldCamera, out Vector2 _localPosition);
            return _localPosition;
        }

        public static string FormatTime(float _time)
        {
            int _minutes = Mathf.FloorToInt(_time / 60f);
            int _seconds = Mathf.FloorToInt(_time % 60f);
            return string.Format("{0:00}:{1:00}", _minutes, _seconds);
        }

        public static bool IsLongScreen()
        {
            return (float)Screen.currentResolution.width / (float)Screen.currentResolution.height < 9f / 16f;
        }

        public static void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Random.Range(0, n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static List<int> ShuffleNumber(int start, int end)
        {
            List<int> _list = new List<int>();
            for (int i = start; i <= end; i++)
            {
                _list.Add(i);
            }
            Helpers.Shuffle(_list);
            return _list;
        }

        public static T GetRandomEnum<T>(T _min, T _max)
        {
            System.Array A = System.Enum.GetValues(typeof(T));
            T V = (T)A.GetValue(UnityEngine.Random.Range((int)(object)_min, (int)(object)_max));
            return V;
        }

        public static List<T> GetAllEnum<T>()
        {

            List<T> enumValues = new();
            foreach (T value in System.Enum.GetValues(typeof(T)))
            {
                enumValues.Add(value);
            }
            return enumValues;
        }

        public static Vector2 PerpendicularVector(Vector2 direction, Vector2 point)
        {
            // Calculate the perpendicular vector
            Vector2 perpVector = new Vector2(-direction.y, direction.x);

            // Calculate the vector that passes through the point
            Vector2 resultVector = point + perpVector;

            return resultVector;
        }

        public static bool GetMousePostionOnPlane(Ray _ray, Plane _plane, out Vector3 _hitPoint)
        {
            if (_plane.Raycast(_ray, out float enter))
            {
                _hitPoint = _ray.GetPoint(enter);
                return true;
            }
            else
            {
                _hitPoint = Vector3.zero;
                return false;
            }
        }

        public static bool GetMousePostionOnCollider(Ray _ray, LayerMask _mask, out Vector3 _hitPoint)
        {
            if (Physics.Raycast(_ray, out RaycastHit _raycastHitPoint, Mathf.Infinity, _mask))
            {
                _hitPoint = _raycastHitPoint.point;
                return true;
            }
            else
            {
                _hitPoint = Vector3.zero;
                return false;
            }
        }

        public static bool GetMousePostionOnCollider(Ray _ray, LayerMask _mask, out RaycastHit _raycastHit)
        {
            if (Physics.Raycast(_ray, out RaycastHit _raycastHitPoint, Mathf.Infinity, _mask))
            {
                _raycastHit = _raycastHitPoint;
                return true;
            }
            else
            {
                _raycastHit = new RaycastHit();
                return false;
            }
        }

        public static bool PhysicRaycast2D(Camera _cam, out RaycastHit2D _hit)
        {
            // Cast a ray from the mouse position
            _hit = Physics2D.Raycast(_cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (_hit.collider != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static float ParseFloatWithPoint(string _value)
        {
            if (_value.Contains(","))
                _value = _value.Replace(",", ".");

            if (float.TryParse(_value, out float _result))
            {
                return _result;
            }
            else
            {
                Debug.LogError("Fail to parse: " + _value);
                return 0;
            }
        }

        public static IEnumerator IEGetRequest(string _uri, System.Action<bool, string> _onCompleted)
        {
            UnityWebRequest _webRequest = UnityWebRequest.Get(_uri);
            yield return _webRequest.SendWebRequest();
            //
            if (_webRequest.result == UnityWebRequest.Result.ConnectionError || _webRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                _onCompleted.Invoke(false, _webRequest.error);
            }
            else
            {
                string _jsonResponse = _webRequest.downloadHandler.text;
                _onCompleted.Invoke(true, _jsonResponse);
            }
        }

        public static void LogCaller(string _message = " ",
    [System.Runtime.CompilerServices.CallerLineNumber] int line = 0
    , [System.Runtime.CompilerServices.CallerMemberName] string membername = ""
    , [System.Runtime.CompilerServices.CallerFilePath] string filePath = ""
    )
        {
            if (!DPDebug.IsShow) return;
            //DPDebug.Log($"<color=green>Log with _message {_message}: </color> {line} :: {membername} :: {filePath}");
        }

        public static void LogErrorCaller(string _message = " ",
    [System.Runtime.CompilerServices.CallerLineNumber] int line = 0
, [System.Runtime.CompilerServices.CallerMemberName] string membername = ""
, [System.Runtime.CompilerServices.CallerFilePath] string filePath = ""
)
        {
            if (!DPDebug.IsShow) return;
            DPDebug.LogError($"<color=green>Log with _message {_message}: </color> {line} :: {membername} :: {filePath}");
        }

        public static List<T> GetDistinctElements<T>(List<T> list, int n, T _exclude = default)
        {
            var distinctElements = new HashSet<T>();
            var random = new System.Random();

            // Filter out the excluded element if provided and get distinct elements
            var filteredList = new List<T>(list);
            if (!EqualityComparer<T>.Default.Equals(_exclude, default))
            {
                filteredList.RemoveAll(item => item.Equals(_exclude));
            }

            while (distinctElements.Count < n && filteredList.Count > 0)
            {
                var index = random.Next(filteredList.Count);
                var element = filteredList[index];
                distinctElements.Add(element);
            }

            return new List<T>(distinctElements);
        }

        public static Vector3? GetMouseClickPointOnPlane(Plane plane)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (plane.Raycast(ray, out float enter))
                {
                    return ray.GetPoint(enter);
                }
            }
            return null;
        }

        public static Vector3 GetRandomPositionXZ(Vector3 _position, float _distance)
        {
            float x = Random.Range(-_distance, _distance);
            float z = Random.Range(-_distance, _distance);
            return new Vector3(_position.x + x, _position.y, _position.z + z);
        }

        public static Vector3 GetRandomPositionXY(Vector3 _position, float _distance)
        {
            float x = Random.Range(-_distance, _distance);
            float y = Random.Range(-_distance, _distance);
            return new Vector3(_position.x + x, _position.y + y, _position.z);
        }

        public static Vector3 GetRandomPosInRadius(Vector3 center, float radius)
        {
            float x = Random.Range(center.x - radius, center.x + radius);
            float y = Random.Range(center.y - radius, center.y + radius);
            float z = Random.Range(center.z - radius, center.z + radius);
            return new Vector3(x, y, z);
        }
        
#if UNITY_EDITOR
        public static int GetHash(GameObject prefab)
        {
            string path = AssetDatabase.GetAssetPath(prefab);
            return path.GetHashCode();
        }
#endif


#if UNITY_EDITOR
        public static T GetAsset<T>(string name = "") where T : Object
        {
            string[] assets = AssetDatabase.FindAssets((string.IsNullOrEmpty(name) ? "" : name + " ") + "t:" + typeof(T).Name);
            if (assets.Length > 0)
            {
                return (T)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(assets[0]), typeof(T));
            }

            return null;
        }
#endif

        public static Sequence PlayHandTUT(Transform pivot, Vector3 startPos, Vector3 endPos, Image img = null, SpriteRenderer sprite = null, bool isLoop = true, Vector3 originScale = default)
        {
            if (originScale == default)
                originScale = Vector3.one;
            Sequence _seq = DOTween.Sequence();
            if (img != null)
            {
                img.gameObject.SetActive(true);
                img.transform.localScale = originScale * 1.2f;
                img.transform.position = startPos;
                var color = img.color;
                color.a = 1f;
                img.color = color;
                _seq.Append(img.transform.DOScale(originScale, 0.5f).SetEase(Ease.InOutSine));
                _seq.Append(img.transform.DOMove(endPos, 0.5f).SetEase(Ease.InOutSine));
                _seq.Append(img.transform.DOScale(originScale * 1.3f, 0.5f).SetEase(Ease.InOutSine));
                _seq.Append(img.DOFade(0f, 0.5f));
            }
            else if (sprite != null)
            {
                pivot.gameObject.SetActive(true);
                pivot.transform.localScale = Vector3.one * 1.2f;
                pivot.transform.position = startPos;
                var color = sprite.color;
                color.a = 1f;
                sprite.color = color;
                _seq.Append(pivot.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.InOutSine));
                _seq.Append(pivot.transform.DOMove(endPos, 0.5f).SetEase(Ease.InOutSine));
                _seq.Append(pivot.transform.DOScale(Vector3.one * 1.3f, 0.5f).SetEase(Ease.InOutSine));
                _seq.Append(sprite.DOFade(0f, 0.5f));
            }
            if (isLoop)
            {
                _seq.AppendInterval(0.5f); // Thêm delay trước khi lặp lại
                _seq.SetLoops(-1, LoopType.Restart); // Lặp vô hạn
            }
            return _seq;
        }

        public static Sequence PlayNotifyWinLevel(Image img)
        {
            Sequence _seq = DOTween.Sequence();
            if (img != null)
            {
                img.gameObject.SetActive(true);
                img.transform.localScale = Vector3.one * 0.5f;
                var color = img.color;

                img.color = color;
                _seq.Append(img.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack));
                _seq.Join(img.DOFade(1f, 0.5f));
                _seq.AppendInterval(1f);
                _seq.Append(img.transform.DOScale(Vector3.one * 1.2f, 0.5f).SetEase(Ease.InBack));
                _seq.Join(img.DOFade(0f, 0.5f));
                _seq.OnComplete(() => img.gameObject.SetActive(false));
            }

            return _seq;
        }

        public static Sequence PlayAnimShow(Transform target, float startScale = 0, float endScale = 1)
        {
            Sequence _seq = DOTween.Sequence();
            target.gameObject.SetActive(true);
            target.localScale = Vector3.one * startScale;
            _seq.Append(target.DOScale(Vector3.one * endScale, 0.5f).SetEase(Ease.OutBack));
            _seq.AppendInterval(1f);
            _seq.OnComplete(() => target.gameObject.SetActive(false));
            return _seq;
        }

        //===================================================
        #region [DEBUG]
        //debug draw sphere
        public static void DrawWireSphere(Vector3 center, float radius, Color color, float duration = 0, bool depthTest = true)
        {
            int segments = 24;
            float step = 360f / segments;

            // Vòng ngang XY
            for (int i = 0; i < segments; i++)
            {
                Vector3 p1 = center + Quaternion.Euler(0, step * i, 0) * Vector3.forward * radius;
                Vector3 p2 = center + Quaternion.Euler(0, step * (i + 1), 0) * Vector3.forward * radius;
                Debug.DrawLine(p1, p2, color, duration, depthTest);
            }

            // Vòng dọc XZ
            for (int i = 0; i < segments; i++)
            {
                Vector3 p1 = center + Quaternion.Euler(step * i, 0, 0) * Vector3.up * radius;
                Vector3 p2 = center + Quaternion.Euler(step * (i + 1), 0, 0) * Vector3.up * radius;
                Debug.DrawLine(p1, p2, color, duration, depthTest);
            }

            // Vòng dọc YZ
            for (int i = 0; i < segments; i++)
            {
                Vector3 p1 = center + Quaternion.Euler(0, 0, step * i) * Vector3.up * radius;
                Vector3 p2 = center + Quaternion.Euler(0, 0, step * (i + 1)) * Vector3.up * radius;
                Debug.DrawLine(p1, p2, color, duration, depthTest);
            }
        }

        public static void ClearUnityConsole()
        {
#if UNITY_EDITOR
            var assembly = System.Reflection.Assembly.GetAssembly(typeof(SceneView));
            var type = assembly.GetType("UnityEditor.LogEntries");
            var method = type.GetMethod("Clear");
            method.Invoke(null, null);
#endif
        }


        //===================================================
        #region [Mathf 2D]
        public static bool IsPointOnLineSegment(Vector2Int point, Vector2Int lineStart, Vector2Int lineEnd)
        {
            // Kiểm tra xem 3 điểm có thẳng hàng không
            Vector2Int v1 = point - lineStart;
            Vector2Int v2 = lineEnd - lineStart;

            // Cross product = 0 nghĩa là thẳng hàng
            int crossProduct = v1.x * v2.y - v1.y * v2.x;
            if (crossProduct != 0) return false;

            // Kiểm tra point có nằm trong bounds của line segment không
            int minX = Mathf.Min(lineStart.x, lineEnd.x);
            int maxX = Mathf.Max(lineStart.x, lineEnd.x);
            int minY = Mathf.Min(lineStart.y, lineEnd.y);
            int maxY = Mathf.Max(lineStart.y, lineEnd.y);

            return point.x >= minX && point.x <= maxX && point.y >= minY && point.y <= maxY;
        }
        #endregion
        //===================================================
        #endregion
        //===================================================
    }
}