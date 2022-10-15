using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    public void StartLaunch() {
        if (Rocket.Instance.ReadyToLaunch()) {
            Rocket.Instance.Launch();
            UIManager.Instance.ShowBuildPanel(false);
            CamerasManager.Instance.EnableGameCamera(true);
        }  
    }
}
