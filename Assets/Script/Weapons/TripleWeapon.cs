using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleWeapon : Weapon
{
    [SerializeField]
    private List<Weapon> weapons = new List<Weapon>();

    public override void Shot()
    {
        if (_canShoot) {
            foreach (Weapon weapon in weapons)
                weapon.Shot();

            if (usesCoolDown)
                StartCoroutine(StartCD());
        }
    }
}
