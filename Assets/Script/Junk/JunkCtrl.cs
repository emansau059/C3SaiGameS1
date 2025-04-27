using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : ThanhMonoBehaviour
{
    [SerializeField] protected Transform _model;
    public Transform model => _model;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
    }
    protected virtual void LoadModel()
    {
        if (this._model != null) return;
        this._model = transform.Find("Model");
        Debug.Log(transform.name + "Load Model", gameObject);
    }

}
