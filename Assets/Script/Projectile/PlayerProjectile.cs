using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : Projectile
{
    protected override void OnHit(Collision2D collision) {
        if(collision.gameObject.tag == "Obstacle")
            Destroy(collision.gameObject);
        base.OnHit(collision);
    }
}
