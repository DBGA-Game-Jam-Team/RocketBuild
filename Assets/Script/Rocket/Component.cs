using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{
    public int ID { get => id; }
    [SerializeField] protected int id;
}
