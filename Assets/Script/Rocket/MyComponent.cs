using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyComponent : MonoBehaviour
{
    public int ID { get; set; }
    public Sprite ComponenetSprite { get => sprite;}

    [SerializeField]
    private Sprite sprite;

    //public int ID { get => id; }
    //[SerializeField] protected int id;
}
