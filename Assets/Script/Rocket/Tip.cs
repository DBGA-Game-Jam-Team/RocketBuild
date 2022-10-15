using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tip : MyComponent {
    public int Life { get => life; }
    public Weapon Weapon { get=> weapon; }

    [SerializeField] private int life;

    [SerializeField] private Weapon weapon;
}
