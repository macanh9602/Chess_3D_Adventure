using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTLTools;

namespace DP.Utilities
{
    public static class DPDebug
    {
        private static string KEY_DEBUG_SHOW = "OneGame.Debug.Show";
        public static bool IsShow
        {
            private set
            {
                VTLPlayerPrefs.SetBool(KEY_DEBUG_SHOW, value);
            }
            get
            {
#if UNITY_EDITOR
                return true;
#else
                return VTLPlayerPrefs.GetBool(KEY_DEBUG_SHOW, false);
#endif
            }
        }
        public static void Show()
        {
            IsShow = true;
        }
        public static void Hide()
        {
            IsShow = false;
        }
        // 
        #region [LOG]

        public static void Log(object _message)
        {
            if (!IsShow) return;
            Debug.Log(_message);


              
        }
        public static void Log(object _message, Object _context)
        {
            if (!IsShow) return;
            Debug.Log(_message, _context);
        }
        public static void LogFormat(string _format, params object[] _args)
        {
            if (!IsShow) return;
            Debug.LogFormat(_format, _args);
        }
        public static void LogFormat(Object _context, string _format, params object[] _args)
        {
            if (!IsShow) return;
            Debug.LogFormat(_context, _format, _args);
        }

        #endregion

        #region [WARNING]

        public static void LogWarning(object _message)
        {
            if (!IsShow) return;
            Debug.LogWarning(_message);
        }
        public static void LogWarning(object _message, Object _context)
        {
            if (!IsShow) return;
            Debug.LogWarning(_message, _context);
        }
        public static void LogWarningFormat(string _format, params object[] _args)
        {
            if (!IsShow) return;
            Debug.LogWarningFormat(_format, _args);
        }
        public static void LogWarningFormat(Object _context, string _format, params object[] _args)
        {
            if (!IsShow) return;
            Debug.LogWarningFormat(_context, _format, _args);
        }

        #endregion

        #region [ERROR]

        public static void LogError(object _message)
        {
            if (!IsShow) return;
            Debug.LogError(_message);
        }
        public static void LogError(object _message, Object _context)
        {
            if (!IsShow) return;
            Debug.LogError(_message, _context);
        }
        public static void LogErrorFormat(string _format, params object[] _args)
        {
            if (!IsShow) return;
            Debug.LogErrorFormat(_format, _args);
        }
        public static void LogErrorFormat(Object _context, string _format, params object[] _args)
        {
            if (!IsShow) return;
            Debug.LogErrorFormat(_context, _format, _args);
        }

        #endregion

        #region [EXCEPTION]

        public static void LogException(System.Exception _exception)
        {
            if (!IsShow) return;
            Debug.LogException(_exception);
        }
        public static void LogException(System.Exception _exception, Object _context)
        {
            if (!IsShow) return;
            Debug.LogException(_exception, _context);
        }

        #endregion

        #region [ASSERTION]

        public static void LogAssertion(object _message)
        {
            if (!IsShow) return;
            Debug.LogAssertion(_message);
        }
        public static void LogAssertion(object _message, Object _context)
        {
            if (!IsShow) return;
            Debug.LogAssertion(_message, _context);
        }
        public static void LogAssertionFormat(string _format, params object[] _args)
        {
            if (!IsShow) return;
            Debug.LogAssertionFormat(_format, _args);
        }
        public static void LogAssertionFormat(Object _context, string _format, params object[] _args)
        {
            if (!IsShow) return;
            Debug.LogAssertionFormat(_context, _format, _args);
        }

        #endregion
    }
}