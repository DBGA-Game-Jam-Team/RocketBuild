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

    public static Action<Component, Vector2> OnMouseHover; // pass infos thorugh here
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

    private void ShowPanel(Component component, Vector2 mousePos) // add infos here
    {
        infoPanel.gameObject.SetActive(true);
        infoPanel.transform.position = new Vector2(mousePos.x + infoPanel.sizeDelta.x - 100.0f, mousePos.y);
    }

    private void HidePanel()
    {
        // reset infos here
        infoPanel.gameObject.SetActive(false);
    }
}
