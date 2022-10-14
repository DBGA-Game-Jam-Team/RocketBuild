using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : Projectile
{
    protected override void OnHit(Collision2D collision) {
        //if (collision.gameObject.tag == "Player")
            //TODO CALL GAMEOVER
        base.OnHit(collision);
    }
}
