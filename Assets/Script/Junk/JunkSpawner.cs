using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    private static JunkSpawner _instance;
    public static JunkSpawner instance => _instance;

    public static string mateoriteOne = "Mateorite_1";

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
