using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyComponent : MonoBehaviour
{
    public int ID { get; set; }
    public Sprite ComponenetSprite { get; protected set; }

    protected void Awake()
    {
        ComponenetSprite = GetComponent<SpriteRenderer>().sprite;
    }

    //public int ID { get => id; }
    //[SerializeField] protected int id;
}
