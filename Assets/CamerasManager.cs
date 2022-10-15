using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasManager : Singleton<CamerasManager>
{
    [SerializeField] GameObject BuildCamera;
    [SerializeField] GameObject GameCamera;

    private void Start() {
        BuildCamera.SetActive(true);
        GameCamera.SetActive(false);
    }

    public void EnableGameCamera(bool _enable) {
        GameCamera.SetActive(_enable);
        BuildCamera.SetActive(!_enable);
    }

}
