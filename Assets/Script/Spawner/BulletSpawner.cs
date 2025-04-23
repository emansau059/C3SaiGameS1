using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    private static BulletSpawner _instance;
    public static BulletSpawner instance => _instance;

    public static string bulletOne = "Bullet_1";

    protected override void Awake()
    {
        base.Awake();
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
        {
            Destroy(this.gameObject);
        }
    }
}
