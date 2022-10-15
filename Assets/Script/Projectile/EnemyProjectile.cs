using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : Projectile
{
    protected override void OnHit(Collision2D collision) {
        Debug.Log(collision.gameObject.name);
        base.OnHit(collision);
    }
}
