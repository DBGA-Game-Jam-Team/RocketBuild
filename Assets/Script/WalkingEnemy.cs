using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : MonoBehaviour
{
    [SerializeField] float speed;
    private bool isGoingRight;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        int val = Random.Range(0, 2);
        if(val == 0) isGoingRight = true;
        else isGoingRight = false;
    }

    private void Update() {
        if (isGoingRight)
            rb.velocity = new Vector2(speed, 0);
        else 
            rb.velocity = new Vector2(-speed, 0);

        if (transform.position.x >= GameController.Instance.XRightMargin) isGoingRight = false;
        else if (transform.position.x <= GameController.Instance.XLeftMargin) isGoingRight = true;
        
    }
}
