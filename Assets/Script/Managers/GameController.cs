using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : Singleton<GameController>
{

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
        Time.timeScale = 0;
        UIManager.Instance.ShowGameOverPanel();
    }

    public void PlayAgain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame() {
        Application.Quit();
    }

    public void StartGame() {
        UIManager.Instance.AnimateInBuildPanel();
    }


}
