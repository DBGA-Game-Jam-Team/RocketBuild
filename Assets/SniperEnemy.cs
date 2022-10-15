using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperEnemy : AbsEnemy
{
    [SerializeField] Weapon weapon;

    protected override void Shot() {
        if(weapon.gameObject.transform.position.y > Rocket.Instance.gameObject.transform.position.y) {
            weapon.gameObject.transform.up = (Rocket.Instance.transform.position - weapon.gameObject.transform.position).normalized;
            weapon.GenericShot();
        }
    }
    

}
