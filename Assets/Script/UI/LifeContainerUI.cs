using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeContainerUI : MonoBehaviour
{
    [SerializeField]
    private GameObject heartPrefab;

    private List<Heart> hearts = new List<Heart>();

    public void Start()
    {
        for(int i=0; i<Rocket.Instance.Life; i++)
        {
            GameObject heart = Instantiate(heartPrefab, transform);
            Heart h =  heart.GetComponent<Heart>();
            h.Full();
            hearts.Add(h);
        }
    }

    public void SetLife(int _life) {
        for(int i = 0; i < _life; i++) {
            hearts[i].Full();
        }
        for(int i = _life; i < hearts.Count; i++) {
            hearts[i].Empty();
        }
    }

    //public void RemoveLife()
    //{
    //    for (int i = hearts.Count-1; i >= 0; ++i)
    //    {
    //        if (!hearts[i].IsFull)
    //        {
    //            hearts[i].Empty();
    //            return;
    //        }
    //    }
    //}
}
