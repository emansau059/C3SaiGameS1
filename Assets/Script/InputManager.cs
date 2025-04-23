using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public static InputManager instance => _instance;
    [SerializeField] private Vector3 _mouseWorldPos;
    public Vector3 mouseWorldPos => _mouseWorldPos;
    [SerializeField] private float _onFiring;
    public float onFiring => _onFiring;
    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        else if(_instance.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
        {
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        this.GetMouseDown();
    }

    private void FixedUpdate()
    {
        this.GetMousePos();
    }
    protected virtual void GetMouseDown()
    {
        this._onFiring = Input.GetAxis("Fire1");
    }
    protected virtual void GetMousePos()
    {
        this._mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

}
