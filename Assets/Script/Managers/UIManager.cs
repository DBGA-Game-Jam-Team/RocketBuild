using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] GameObject BuildPanel;
    [SerializeField] CountDownText countDownText;
    [SerializeField] GameObject GameInfoPanel;
    [SerializeField] TextMeshProUGUI distanceText;
    [SerializeField] LifeContainerUI lifeContainer;
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] TextMeshProUGUI scoreText;

    public void ShowGameInfoPanel(bool _show)
    {
        GameInfoPanel.SetActive(_show);
    }

    public void ShowBuildPanel(bool _show) {
        BuildPanel.SetActive(_show);
    }
    public void ShowGameOverPanel() {
        ShowGameInfoPanel(false);
        GameOverPanel.SetActive(true);
        scoreText.text = "Score: " + Rocket.Instance.Distance;
    }

    public void StartCountDownText(int _time) {
        countDownText.StartCountDown(_time);
    }

    public void ShowDistance(int distance) {
        distanceText.text = distance.ToString();
    }

    public void UpdateLifeContainer(int _life) {
        lifeContainer.SetLife(_life);
    }


}
