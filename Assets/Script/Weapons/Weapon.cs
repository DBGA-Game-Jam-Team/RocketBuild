using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Weapon : MonoBehaviour
{
    public static event Action OnCooldownBegin;

    public float Cooldown { get => coolDown; }

    [SerializeField] protected float coolDown;
    [SerializeField] protected GameObject projectilePrefab;

    private bool _canShoot = true;

    public void Shot() {
        if (!_canShoot)
            return;
        Instantiate(projectilePrefab,transform.position,Quaternion.identity).GetComponent<Projectile>().Shot(transform.up);
        StartCoroutine(StartCD());
    }

    private IEnumerator StartCD()
    {
        OnCooldownBegin?.Invoke();
        _canShoot = false;
        yield return new WaitForSeconds(coolDown);
        _canShoot = true;
    }
}
