using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] GameObject BuildPanel;
    [SerializeField] GameObject LaunchButton;
    [SerializeField] CountDownText countDownText;
    public void ShowBuildPanel(bool _show) {
        BuildPanel.SetActive(_show);
        LaunchButton.SetActive(_show);
    }

    public void StartCountDownText(int _time) {
        countDownText.StartCountDown(_time);
    }
}
