using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] protected float coolDown;
    [SerializeField] protected GameObject projectilePrefab;

    public void Shot() {
        Instantiate(projectilePrefab,transform.position,Quaternion.identity).GetComponent<Projectile>().Shot(transform.forward);
    }
}
