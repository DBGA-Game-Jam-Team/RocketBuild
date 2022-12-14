using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelUI : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    private float maxFuel;

    private void Start()
    {
        slider.value = 1;
        maxFuel = Rocket.Instance.Fuel;
    }

    private void Update()
    {
        slider.value = Rocket.Instance.Fuel / maxFuel;
    }
}
