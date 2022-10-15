using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ComponentUI : MonoBehaviour
{
    private MyComponent component;

    [SerializeField]
    private Image componentImage;
    [SerializeField]
    private TextMeshProUGUI infoText;


    public void SetComponentUI(MyComponent comp)
    {
        component = comp;
        componentImage.sprite = comp.ComponenetSprite;

        infoText.text = "";
        //THRUSTER
        if (component is Thruster) {
            Thruster thruster = (Thruster)component;
            infoText.text = "S: " + thruster.YSpeed;
      }
        //BODY
        else if (comp is Body) {
            Body body = (Body)comp;
            infoText.text = "L: " + body.Life + "F: "+body.Fuel;

        }
        // TIP
        else if (comp is Tip){
            string weapon = null;
            Tip tip = (Tip)component;
            if (tip.Weapon) {
                if (tip.Weapon.GetComponent<Weapon>()) weapon = "1";
                else if (tip.Weapon.GetComponent<TripleWeapon>()) weapon = "2";
            }
            else weapon = "0";

            infoText.text = "L: " + tip.Life.ToString() + "D: " + weapon;
        }
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
