using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasManager : Singleton<CamerasManager>
{
    [SerializeField] GameObject BuildCamera;
    [SerializeField] GameObject GameCamera;
    [SerializeField] GameObject LaunchCamera;

    private void Start() {
        EnableBuildCamera();
    }

    public void EnableBuildCamera() {
        BuildCamera.SetActive(true);
        GameCamera.SetActive(false);
        LaunchCamera.SetActive(false);
    }
    public void EnableGameCamera() {
        BuildCamera.SetActive(false);
        GameCamera.SetActive(true);
        LaunchCamera.SetActive(false);
    }

    public void EnableLaunchCamera() {
        BuildCamera.SetActive(false);
        GameCamera.SetActive(false);
        LaunchCamera.SetActive(true);
    }

}
