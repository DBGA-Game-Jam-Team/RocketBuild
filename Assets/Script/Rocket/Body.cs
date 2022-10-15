using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MyComponent {
    public int Life { get => life; }
    public int Fuel { get => fuel; }

    [SerializeField] int life;
    [SerializeField] int fuel;
}
