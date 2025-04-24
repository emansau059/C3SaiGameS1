using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : ThanhMonoBehaviour
{
    private static GameCtrl _instance;
    public static GameCtrl instance => _instance;
    [SerializeField] protected Camera _mainCamera;
    public Camera MainCamera => _mainCamera;
    protected override void Awake()
    {
        base.Awake();
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
        {
            Destroy(this.gameObject);
        }
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCamera();
    }
    protected virtual void LoadCamera()
    {
        if (this._mainCamera != null) return;
        this._mainCamera = GameCtrl.FindObjectOfType<Camera>();
        Debug.Log(transform.name + "Load Camera", gameObject);
    }
}
