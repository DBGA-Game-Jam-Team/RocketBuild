using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    [SerializeField] private float ySpeed;
    [SerializeField] private float xSpeed;
    [SerializeField] private int fuel;
    [SerializeField] private int life;

    public Tip Tip { get; set; }
    public Body Body { get;set; }
    public Thruster Thruster {get;set;}

}
