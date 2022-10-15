using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : Singleton<Rocket> {

    [SerializeField] private float ySpeed = 0f;
    [SerializeField] private float xSpeed = 0f;
    [SerializeField] private float fuel = 0f;
    [SerializeField] private int life = 0;

    [SerializeField] private GameObject tipSlot;
    [SerializeField] private GameObject bodySlot;
    [SerializeField] private GameObject thrusterSlot;

    public Tip Tip { get; private set; }
    public Body Body { get; private set; }
    public Thruster Thruster {get; private set; }

    public void EquipTip(Tip tip)
    {
        Tip = tip;
        tipSlot.GetComponent<SpriteRenderer>().sprite = tip.ComponenetSprite;
    }

    public void EquipBody(Body body)
    {
        Body = body;
        bodySlot.GetComponent<SpriteRenderer>().sprite = body.ComponenetSprite;
    }

    public void EquipThruster(Thruster thruster)
    {
        Thruster = thruster;
        thrusterSlot.GetComponent<SpriteRenderer>().sprite = thruster.ComponenetSprite;
    }

    public void Launch() {
        life += Tip.Life;

        life += Body.Life;
        fuel += Body.Fuel;

        xSpeed += Thruster.XSpeed;
        ySpeed += Thruster.YSpeed;
    }
}
