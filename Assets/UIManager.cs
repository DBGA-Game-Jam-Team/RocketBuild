using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] GameObject BuildPanel;
    [SerializeField] GameObject LaunchButton;
    [SerializeField] 
    public void ShowBuildPanel(bool _show) {
        BuildPanel.SetActive(_show);
        LaunchButton.SetActive(_show);
    }

    public void StartCountDown(int _time) {

    }
}
