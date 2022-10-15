using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComponentUI : MonoBehaviour
{
    private MyComponent component;

    [SerializeField]
    private Image componentImage;

    public void SetComponentUI(MyComponent comp)
    {
        component = comp;
        componentImage.sprite = comp.ComponenetSprite;
    }

    public void EquipComponent()
    {
        if(component is Thruster)
        {
            Thruster thruster = (Thruster)component;
            Rocket.Instance.EquipThruster(thruster);
        }
        else if (component is Body)
        {
            Body body = (Body)component;
            Rocket.Instance.EquipBody(body);
        }
        else if (component is Tip)
        {
            Tip tip = (Tip)component;
            Rocket.Instance.EquipTip(tip);
        }
    }
}
