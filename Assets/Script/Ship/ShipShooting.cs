using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] private bool _isShooting = false;
    [SerializeField] private float _shootDelay = 1f;
    [SerializeField] private float _shootTimer = 0f;
    private void Update()
    {
        this.Shooting();
        this.IsShooting();
    }
    protected virtual void Shooting()
    {
        if (!this._isShooting) return;
        
        this._shootTimer += Time.fixedDeltaTime;
        if (this._shootTimer < this._shootDelay) return;
        this._shootTimer = 0;

        Vector3 spawnPos = transform.position;
        Quaternion rotation = transform.parent.rotation;
        Transform newBullet = BulletSpawner.instance.Spawn(BulletSpawner.bulletOne, spawnPos, rotation);
        if (newBullet == null) return;

        newBullet.gameObject.SetActive(true);
        Debug.Log("Shooting!");
    }
    protected virtual bool IsShooting()
    {
        this._isShooting = InputManager.instance.onFiring == 1;
        return this._isShooting;
    }
}
