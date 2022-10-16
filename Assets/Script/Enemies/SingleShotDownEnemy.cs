using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShotDownEnemy : AbsEnemy
{
    [SerializeField]
    private Weapon weapon;

    protected override void Shot()
    {
        weapon.Shot();
    }
}
