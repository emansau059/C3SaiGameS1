using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeSpawn : DeSpawnByDistance
{
    protected override void DespawnObject()
    {
        BulletSpawner.instance.Despawn(transform.parent);
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 20f;
    }
}
