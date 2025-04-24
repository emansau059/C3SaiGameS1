using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Observer : MonoBehaviour
{
    private static Observer _instance;
    public static Observer instance => _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if(_instance.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Dictionary<string, List<Action>> _listeners_1 = new Dictionary<string, List<Action>>();

    public bool AddListener(string key, Action value)
    {
        List<Action> actions = new List<Action>();
        if(_listeners_1.ContainsKey(key))
        {
            actions = _listeners_1[key];
        }
        else
        {
            _listeners_1.TryAdd(key, actions);
        }
        _listeners_1[key].Add(value);
        return true;
    }
    public void Notify(string key)
    {
        if(_listeners_1.ContainsKey(key))
        {
            foreach(Action a in _listeners_1[key])
            {
                try
                {
                    a?.Invoke();
                }
                catch(Exception e)
                {
                    Debug.LogError("invoke fail! " + e.ToString());
                }
            }
            return;
        }
        Debug.LogErrorFormat("listener not exist" , key);
    }
}
