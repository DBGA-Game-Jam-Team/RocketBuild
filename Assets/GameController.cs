using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    public float XLeftMargin { get { return leftMargin.position.x; } }
    public float XRightMargin { get { return rightMargin.position.x; } }
    [SerializeField] Transform rightMargin;
    [SerializeField] Transform leftMargin;  
    public void StartLaunch() {
        if (Rocket.Instance.ReadyToLaunch()) {
            Rocket.Instance.Launch();
            UIManager.Instance.ShowBuildPanel(false);
        }  
    }

    public void GameOver() {
        Debug.Log("GameOver");
    }
}
