using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    [SerializeField] float fillPercentage;
    [SerializeField] AudioClip fuelClip;
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player") {
            Rocket.Instance.FillFuel(fillPercentage);
            AudioController.Instance.PlaySFX(fuelClip);
            Destroy(gameObject);
        }
    }
}
