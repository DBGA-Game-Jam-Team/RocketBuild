using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatPanel : MonoBehaviour
{
    [SerializeField]
    private bool isFirstStat;

    [SerializeField]
    private Image iconImage;
    [SerializeField]
    private TextMeshProUGUI valueText;
    [SerializeField]
    private TextMeshProUGUI nameText;

    [Header("Icons")]
    [SerializeField]
    private Sprite icoBullet;
    [SerializeField]
    private Sprite icoHeart;
    [SerializeField]
    private Sprite icoThunder;
    [SerializeField]
    private Sprite icoSWheel;
    [SerializeField]
    private Sprite icoFuel;


    public void SetPanel(MyComponent component)
    {
        nameText.text = component.ComponentName;
        if (component is Thruster)
        {
            Thruster thruster = (Thruster)component;
            if (isFirstStat)
            {
                iconImage.sprite = icoThunder;
                valueText.text = "x" + thruster.YSpeed;
            }
            else
            {
                iconImage.sprite = icoSWheel;
                valueText.text = "x" + thruster.XSpeed;
            }
        }
        else if (component is Body)
        {
            Body body = (Body)component;
            if (isFirstStat)
            {
                iconImage.sprite = icoHeart;
                valueText.text = "x" + body.Life;
            }
            else
            {
                iconImage.sprite = icoFuel;
                valueText.text = "x" + body.Fuel;
            }
        }
        else if (component is Tip)
        {
            Tip tip = (Tip)component;
            if (isFirstStat)
            {
                iconImage.sprite = icoHeart;
                valueText.text = "x" + tip.Life;
            }
            else
            {
                iconImage.sprite = icoBullet;
                if(tip.Weapon == null)
                {
                    valueText.text = "x" + 0;
                }
                else
                {
                    if(tip.Weapon is TripleWeapon)
                    {
                        valueText.text = "x" + 3;
                    }
                    else
                    {
                        valueText.text = "x" + 1;
                    }
                }
            }
        }
    }
}
