using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDeSpawn : DeSpawnByDistance
{
    protected override void DespawnObject()
    {
        JunkSpawner.instance.Despawn(transform.parent);
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 20f;
    }
}
