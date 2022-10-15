using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    [SerializeField] float speed;

    public void Shot(Vector2 _dir) {
        GetComponent<Rigidbody2D>().velocity = _dir.normalized * (speed+Rocket.Instance.YSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        OnHit(collision);
        Destroy(gameObject);
    }

    protected virtual void OnHit(Collision2D collision) { 
    
    }
}
