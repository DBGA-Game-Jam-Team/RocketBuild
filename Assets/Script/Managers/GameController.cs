using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : Singleton<GameController>
{
    [SerializeField]
    private AudioClip gameoverClip;

    private void Start() {
        Time.timeScale = 1f;
    }

    public float XLeftMargin { get { return leftMargin.position.x; } }
    public float XRightMargin { get { return rightMargin.position.x; } }
    [SerializeField] Transform rightMargin;
    [SerializeField] Transform leftMargin;  
    public void StartLaunch() {
        if (Rocket.Instance.ReadyToLaunch()) {
            Rocket.Instance.Launch();
            UIManager.Instance.AnimateOutBuildPanel();
        }  
    }

    public void GameOver() {
        AudioController.Instance.PlaySFX(gameoverClip);
        Time.timeScale = 0;
        UIManager.Instance.ShowGameOverPanel();
    }

    public void PlayAgain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame() {
        Application.Quit();
    }
}
