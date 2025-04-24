using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : ThanhMonoBehaviour
{
    [SerializeField] protected JunkCtrl junkCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkCtrl();
    }

    protected virtual void LoadJunkCtrl()
    {
        if (this.junkCtrl != null) return;
        this.junkCtrl = this.GetComponent<JunkCtrl>();
        Debug.Log(transform.name + "Load JunkCtrl", gameObject);
    }

    protected override void Start()
    {
        this.JunkSpawning();
    }
    protected virtual void JunkSpawning()
    {
        Transform ranPoint = this.junkCtrl.SpawnPoints.GetRandom(); 
        Vector3 pos = ranPoint.position;
        Quaternion rotation = transform.rotation;
        Transform obj = this.junkCtrl.JunkSpawner.Spawn(JunkSpawner.mateoriteOne, pos, rotation);
        obj.gameObject.SetActive(true);
        Invoke(nameof(this.JunkSpawning), 1f);
    }
}
