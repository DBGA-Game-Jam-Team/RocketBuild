using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    public bool IsFull { get; private set; }

    [SerializeField]
    private Sprite emptyHeart;
    [SerializeField]
    private Sprite fullHeart;
    [SerializeField]
    private Image image;

    private void Start()
    {
        IsFull = false;
    }

    public void Empty()
    {
        IsFull = false;
        image.sprite = emptyHeart;
    }

    public void Full()
    {
        IsFull = true;
        image.sprite = fullHeart;
    }
}
