using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : ThanhMonoBehaviour
{
    [SerializeField] protected float _speed = 2f;
    public float speed => _speed;
    [SerializeField] protected Transform _target;
    public Transform target => _target;

    protected virtual void FixedUpdate()
    {
        this.Following();
    }
    protected virtual void Following()
    {
        if (this._target == null) return;
        transform.position = Vector3.Lerp(transform.position, this._target.position, speed * Time.fixedDeltaTime); 
    }
}
