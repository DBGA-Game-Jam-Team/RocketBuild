using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : Component {
    public float XSpeed { get => xSpeed; }
    public float YSpeed { get => ySpeed; }

    [SerializeField] float ySpeed;
    [SerializeField] float xSpeed;
}
