using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelUI : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    private void Start()
    {
        slider.value = 1;
    }

    private void Update()
    {
        
    }
}
