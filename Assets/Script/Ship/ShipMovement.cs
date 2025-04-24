using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _speed;

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.GetTargetPosition(); 
        this.Moving();
        this.LookAtTarget();
    }
    protected virtual void GetTargetPosition()
    {
        this._targetPosition = InputManager.instance.mouseWorldPos;
        this._targetPosition.z = 0;
    }
    protected virtual void LookAtTarget()
    {
        Vector3 dir = this._targetPosition - this.transform.parent.position;
        dir.Normalize();
        float rot_z = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0, 0, rot_z);
    }
    protected virtual void Moving()
    {
        Vector3 newPos = Vector3.Lerp(this.transform.parent.position, _targetPosition, _speed);
        this.transform.parent.position = newPos;
    }
}
