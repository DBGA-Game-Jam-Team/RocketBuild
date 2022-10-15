using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] GameObject BuildPanel;
    public void ShowBuildPanel(bool _show) {
        BuildPanel.SetActive(_show);
    }
}
