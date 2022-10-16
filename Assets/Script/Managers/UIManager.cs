using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] GameObject ComponentsPanel;
    [SerializeField] CountDownText countDownText;
    [SerializeField] GameObject GameInfoPanel;
    [SerializeField] TextMeshProUGUI distanceText;
    [SerializeField] LifeContainerUI lifeContainer;
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject launchButton;

    public void ShowGameInfoPanel(bool _show)
    {
        GameInfoPanel.SetActive(_show);
    }

    public void AnimateOutBuildPanel() {
        ComponentsPanel.GetComponent<Animator>().SetTrigger("PanelOut");
        launchButton.SetActive(false);
    }
    public void HideBuildPanel() {
        ComponentsPanel.SetActive(false);
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
