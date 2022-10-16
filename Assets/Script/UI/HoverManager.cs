using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class HoverManager : MonoBehaviour
{
    [SerializeField]
    private RectTransform infoPanel;
    [SerializeField]
    private StatPanel stat1;
    [SerializeField]
    private StatPanel stat2;

    public static Action<MyComponent, Vector2> OnMouseHover; // pass info thorugh here
    public static Action OnMouseLoseFocus;

    private void OnEnable()
    {
        OnMouseHover += ShowPanel;
        OnMouseLoseFocus += HidePanel;
    }

    private void OnDisable()
    {
        OnMouseHover -= ShowPanel;
        OnMouseLoseFocus -= HidePanel;
    }

    private void Start()
    {
        HidePanel();
    }

    private void ShowPanel(MyComponent component, Vector2 mousePos) // add info here
    {
        stat1.SetPanel(component);
        stat2.SetPanel(component);
        infoPanel.gameObject.SetActive(true);
        infoPanel.transform.position = new Vector2(mousePos.x + infoPanel.sizeDelta.x - 100.0f, mousePos.y);
    }

    private void HidePanel()
    {
        // reset info here
        infoPanel.gameObject.SetActive(false);
    }
}
