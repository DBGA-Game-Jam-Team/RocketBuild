using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPlayer : MonoBehaviour
{
    public void PlaySFX(AudioClip clip)
    {
        AudioController.Instance.PlaySFX(clip);
    }
}
