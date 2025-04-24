using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : ThanhMonoBehaviour
{
    [SerializeField] protected JunkSpawner _junkSpawner;
    public JunkSpawner JunkSpawner => _junkSpawner;
    [SerializeField] protected JunkSpawnPoints _spawnPoints;
    public JunkSpawnPoints SpawnPoints => _spawnPoints;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawner();
        this.LoadSpawnPoints();
    }
    protected virtual void LoadJunkSpawner()
    {
        if (this._junkSpawner != null) return;
        this._junkSpawner = this.GetComponent<JunkSpawner>();
        Debug.Log(transform.name + "Load JunkSpawner", gameObject);
    }
    protected virtual void LoadSpawnPoints()
    {
        if (this._spawnPoints != null) return;
        this._spawnPoints = Transform.FindObjectOfType<JunkSpawnPoints>();
        Debug.Log(transform.name + "Load SpawnPoints", gameObject);
    }
}
