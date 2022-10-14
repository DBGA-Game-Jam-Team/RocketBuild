using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    public float XSpeed { get => xSpeed; }
    public float YSpeed { get => ySpeed; }

    [SerializeField] float ySpeed;
    [SerializeField] float xSpeed;
}
