using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    private void Start()
    {
        SoundManager.instance.PlayBGM("TitleScene");
    }

    public void OnToGameButton()
    {
        SoundManager.instance.PlaySE(0);
    }

    
}
