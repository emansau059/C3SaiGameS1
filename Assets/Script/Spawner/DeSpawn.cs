using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DeSpawn : ThanhMonoBehaviour
{
    protected virtual void FixedUpdate()
    {
        this.Despawning();
    }
    
    protected virtual void Despawning()
    {
        if (!this.CanDespawn()) return;
        this.DespawnObject();
    }
    protected virtual void DespawnObject()
    {
        Destroy(this.transform.parent.gameObject);
    }
    protected abstract bool CanDespawn();
    
}
