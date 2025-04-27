using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JunkAbstract : ThanhMonoBehaviour
{
    [SerializeField] protected JunkCtrl _junkCtrl;
    public JunkCtrl junkCtrl => _junkCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkCtrl();
    }
    protected virtual void LoadJunkCtrl()
    {
        if (this._junkCtrl != null) return;
        this._junkCtrl = transform.parent.GetComponent<JunkCtrl>();
        Debug.Log(transform.name + "Load JunkCtrl", gameObject);
    }
}
