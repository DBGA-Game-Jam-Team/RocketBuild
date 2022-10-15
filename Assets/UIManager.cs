using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] GameObject BuildPanel;
    [SerializeField] GameObject LaunchButton;
    [SerializeField] CountDownText countDownText;
    [SerializeField] GameObject GameInfoPanel;

    public void ShowGameInfoPanel(bool _show)
    {
        GameInfoPanel.SetActive(_show);
    }

    public void ShowBuildPanel(bool _show) {
        BuildPanel.SetActive(_show);
        LaunchButton.SetActive(_show);
    }

    public void StartCountDownText(int _time) {
        countDownText.StartCountDown(_time);
    }
}
