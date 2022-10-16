using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class ComponentUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private MyComponent component;

    [SerializeField]
    private Image componentImage;

    private float timeToWaitHoverPanel = 0.5f;

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

    private void ShowMessage()
    {
        HoverManager.OnMouseHover(component,Mouse.current.position.ReadValue()); // add infos here
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        StopAllCoroutines();
        ShowMessage();
        //StartCoroutine(StartHoverTimer());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        HoverManager.OnMouseLoseFocus();
    }

    private IEnumerator StartHoverTimer()
    {
        yield return new WaitForSeconds(timeToWaitHoverPanel);
        ShowMessage();
    }
}
