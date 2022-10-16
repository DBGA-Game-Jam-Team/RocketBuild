using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFollowCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float offset = 5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(player.position.x, player.position.y+offset, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, player.position.y+offset, transform.position.z);
    }
}
