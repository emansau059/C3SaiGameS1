using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentFly : ThanhMonoBehaviour
{
    [SerializeField] protected float _moveSpeed = 1;
    [SerializeField] protected Vector3 dir = Vector3.right;

    // Update is called once per frame
    void Update()
    {
        this.transform.parent.Translate(dir * _moveSpeed * Time.deltaTime);
    }
}
