using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame() {
        Debug.Log("PlayGameCalled");
        SceneManager.LoadScene(1);
    }
    public void QuitGame() {
        Application.Quit();
    }
}
