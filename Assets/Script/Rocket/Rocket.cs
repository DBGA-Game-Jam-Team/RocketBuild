using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : Singleton<Rocket> {

    [SerializeField] private float ySpeed;
    [SerializeField] private float xSpeed;
    [SerializeField] private int fuel;
    [SerializeField] private int life;

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

}
