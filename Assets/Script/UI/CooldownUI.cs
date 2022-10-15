using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownUI : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    private float maxCD;

    private void Start()
    {
        slider.value = 0;
        if (Rocket.Instance.Tip.Weapon == null)
            return;
        slider.value = 1;
        maxCD = Rocket.Instance.Tip.Weapon.Cooldown;
    }

    private void OnEnable()
    {
        Weapon.OnCooldownBegin += StartCooldownUI;
    }
    private void OnDisable()
    {
        Weapon.OnCooldownBegin -= StartCooldownUI;
    }

    private void StartCooldownUI()
    {
        StartCoroutine(DoCooldown());
    }

    private IEnumerator DoCooldown()
    {
        float currentCD = 0;
        while(currentCD < Rocket.Instance.Tip.Weapon.Cooldown)
        {
            currentCD += 0.01f;
            slider.value = currentCD  / Rocket.Instance.Tip.Weapon.Cooldown;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
