using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMPlayer : MonoBehaviour
{
    [SerializeField]
    private AudioClip menuClip;

    // Update is called once per frame
    void Start()
    {
        if (SceneManager.GetActiveScene().name.Equals("MainMenu"))
        {
            AudioController.Instance.PlayBGM(menuClip);
        }
        if (SceneManager.GetActiveScene().name.Equals("MainScene") && !AudioController.Instance.IsBGMPlaying)
        {
            AudioController.Instance.PlayBGM(menuClip);
        }
    }

}
