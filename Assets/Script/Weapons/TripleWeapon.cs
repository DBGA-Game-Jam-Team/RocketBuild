using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleWeapon : Weapon
{
    [SerializeField]
    private List<Weapon> weapons = new List<Weapon>();

    public override void Shot()
    {
        foreach (Weapon weapon in weapons)
            weapon.GenericShot();

        if(isPlayerWeapon)
            StartCoroutine(StartCD());
    }
}
