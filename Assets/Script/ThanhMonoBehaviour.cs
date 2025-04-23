using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThanhMonoBehaviour : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.LoadComponents();
    }
    protected virtual void Awake()
    {
        this.LoadComponents();
    }
    protected virtual void Start()
    {
        //for override
    }
    protected virtual void LoadComponents()
    {
        //For override
    }
}
