using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using DP.Utilities;

public class PriorityEventDispatcher<K, T, C> where C : IEqualityComparer<K>, new()
{
    public delegate void Handler(K _key, T _data);

    private static Dictionary<K, PriorityList<Listener>> nameToEvent = new Dictionary<K, PriorityList<Listener>>();

    public bool Paused
    {
        get;
        set;
    }

    public PriorityEventDispatcher()
    {
        nameToEvent = new Dictionary<K, PriorityList<Listener>>(new C());
    }

    public void AddListener(K _key, Handler _handler, int _priority = 0)
    {
        PriorityList<Listener> listeners = null;
        if (nameToEvent.TryGetValue(_key, out listeners))
        {
            if (!listeners.Exists(x => x.Handler == _handler))
            {
                listeners.Add(new Listener(_handler, _priority));
            }
            else
            {
                DPDebug.LogWarning(string.Format("PriorityEventDispatcher::AddListener : ({0}, {1}) already added", _key, _handler));
            }
        }
        else
        {
            listeners = new PriorityList<Listener>();
            listeners.Add(new Listener(_handler, _priority));
            nameToEvent[_key] = listeners;
        }
    }

    public void RemoveListener(K _key, Handler _handler)
    {
        PriorityList<Listener> listeners = null;
        if (nameToEvent.TryGetValue(_key, out listeners))
        {
            listeners.RemoveAll(x => x.Handler == _handler);
        }
    }

    public void RemoveAllListeners()
    {
        nameToEvent.Clear();
    }

    public void Dispatch(K _key, T _data)
    {
        if (Paused)
        {
            return;
        }

        PriorityList<Listener> listeners = null;
        if (nameToEvent.TryGetValue(_key, out listeners))
        {
            var copied = listeners.Copy();
            foreach (var i in copied)
            {
                i.Handler(_key, _data);
            }
        }
    }

    class Listener : IComparable<Listener>
    {
        private int priority;
        private Handler handler;

        public Listener(Handler _handler, int _priority = 0)
        {
            this.handler = _handler;
            this.priority = _priority;
        }

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public Handler Handler
        {
            get { return handler; }
        }

        public int CompareTo(Listener other)
        {
            return priority - other.priority;
        }

        public override string ToString()
        {
            return string.Format("[Listener: Priority={0}]", Priority);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Listener other = obj as Listener;
            if ((object)other == null)
            {
                return false;
            }

            return handler.Equals(other.handler);
        }

        public bool Equals(Listener other)
        {
            return handler.Equals(other.handler);
        }
    }

    public static void Test()
    {
        var p = new PriorityList<Listener>();

        bool ok = true;

        for (int i = 0; i < 100; i++)
        {
            p.Add(new Listener(null, UnityEngine.Random.Range(0, 200)));
            ok = ok && p.CheckConsistent();
            DPDebug.Log(string.Format("Consistent ? {0}", p.CheckConsistent()));
        }

        DPDebug.Log(string.Format("{0} - {1}", ok, p));

    }
}
