using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyComponent : MonoBehaviour
{
    public int ID { get; set; }
    public string ComponentName { get => componentName; }
    public Sprite ComponenetSprite { get => sprite;}

    [SerializeField]
    private Sprite sprite;
    [SerializeField]
    private string componentName;

    //public int ID { get => id; }
    //[SerializeField] protected int id;
}
