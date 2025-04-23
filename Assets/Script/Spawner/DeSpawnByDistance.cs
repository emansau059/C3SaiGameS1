using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawnByDistance : DeSpawn
{
    [SerializeField] private float disLimit = 70f;
    [SerializeField] private float distance = 0f;
    [SerializeField] private Camera mainCam;

    protected override void LoadComponents()
    {
        this.LoadCamera();
    }
    protected virtual void LoadCamera()
    {
        if (this.mainCam != null) return;
        this.mainCam = Transform.FindObjectOfType<Camera>();
        Debug.Log(transform.parent.name + "Load camera", gameObject);

    }
    protected override bool CanDespawn()
    {
        this.distance = Vector3.Distance(transform.position, this.mainCam.transform.position);
        if (this.distance > disLimit) return true;
        return false;
    }
}
