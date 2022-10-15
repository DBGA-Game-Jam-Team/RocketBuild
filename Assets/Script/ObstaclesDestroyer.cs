using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesDestroyer : MonoBehaviour
{
    [SerializeField] Transform player;
    private void Update() {
        transform.position = player.position;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Obstacle") || collision.gameObject.tag.Equals("Bullet"))
            Destroy(collision.gameObject);
    }
}
