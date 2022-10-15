using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : Projectile
{
    public override void Shot(Vector2 _dir)
    {
        GetComponent<Rigidbody2D>().velocity = _dir.normalized * (speed + Rocket.Instance.YSpeed);
    }
    protected override void OnHit(Collision2D collision) {
        if(collision.gameObject.tag == "Obstacle")
            Destroy(collision.gameObject);
        base.OnHit(collision);
    }
}
