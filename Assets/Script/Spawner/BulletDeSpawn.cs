using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeSpawn : DeSpawnByTime
{
    protected override void DespawnObject()
    {
        BulletSpawner.instance.Despawn(transform.parent);
    }
}
