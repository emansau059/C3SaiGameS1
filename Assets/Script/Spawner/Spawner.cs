using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : ThanhMonoBehaviour
{
    [SerializeField] private Transform holder;
    [SerializeField] private List<Transform> prefabs;
    [SerializeField] private List<Transform> poolObjs;
    protected override  void Reset()
    {
        this.LoadComponents();
        this.LoadHolder();
    }

    protected override void LoadComponents()
    {
        this.LoadPrefabs();
    }
    protected virtual void LoadHolder()
    {
        if (this.holder != null) return;
        this.holder = transform.Find("Holder");
        Debug.Log(transform.name + "Load Holder", gameObject);
    }
    protected virtual void LoadPrefabs()
    {
        if (this.prefabs.Count > 0) return;

        Transform prefabObj = transform.Find("Prefabs");
        foreach(Transform prefab in prefabObj)
        {
            this.prefabs.Add(prefab);
        }

        this.HidePrefabs();

        Debug.Log(transform.name + ": Load Prefabs", gameObject);
    }
    protected virtual void HidePrefabs()
    {
        foreach(Transform prefab in prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }
    public virtual Transform Spawn( string prefabName, Vector3 spawnPos, Quaternion rotation)
    {
        Transform prefab = this.GetPrefabByName(prefabName);
        if(prefab == null)
        {
            Debug.LogWarning("Prefab not found : " + prefabName);
            return null;
        }
        Transform newPrefab = this.GetObjectFromPool(prefab);
        newPrefab.SetPositionAndRotation(spawnPos, rotation);

        newPrefab.parent = this.holder;
        return newPrefab;
    }
    public virtual void Despawn(Transform obj)
    {
        this.poolObjs.Add(obj);
        obj.gameObject.SetActive(false);
    }
    protected virtual Transform GetObjectFromPool(Transform prefab)
    {
        foreach(Transform poolObj in this.poolObjs)
        {
            if(poolObj.name == prefab.name)
            {
                this.poolObjs.Remove(poolObj);
                return poolObj;
            }
        }

        Transform newPrefab = Instantiate(prefab);
        newPrefab.name = prefab.name;
        return newPrefab;
    }
    public virtual Transform GetPrefabByName(string prefabName)
    {
        foreach(Transform prefab in prefabs)
        {
            if (prefab.name == prefabName) return prefab;
        }
        return null;
    }
    
}
