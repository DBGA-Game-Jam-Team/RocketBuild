using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] GameObject componentsPanel;
    [SerializeField] CountDownText countDownText;
    [SerializeField] GameObject gameInfoPanel;
    [SerializeField] TextMeshProUGUI distanceText;
    [SerializeField] LifeContainerUI lifeContainer;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject launchButton;
    [SerializeField] GameObject mainMenuPanel;

    protected override void Awake() {
        base.Awake();
        componentsPanel.SetActive(false);
    }

    public void ShowGameInfoPanel(bool _show)
    {
        gameInfoPanel.SetActive(_show);
    }

    public void AnimateOutBuildPanel() {
        componentsPanel.GetComponent<Animator>().SetTrigger("PanelOut");
        launchButton.SetActive(false);
    }
    public void HideBuildPanel() {
        componentsPanel.SetActive(false);
    }
    public void AnimateInBuildPanel() {
        StartCoroutine(animateInBuildPanelCor());
    }
    private IEnumerator animateInBuildPanelCor() {
        mainMenuPanel.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        componentsPanel.SetActive(true);
    }

    public void ShowGameOverPanel() {
        ShowGameInfoPanel(false);
        gameOverPanel.SetActive(true);
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
