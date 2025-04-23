using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 dir = Vector3.right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.parent.Translate(this.dir * this._speed * Time.deltaTime);
    }
}
