using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
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
        _canShoot = false;
        yield return new WaitForSeconds(coolDown);
        _canShoot = true;
    }
}
