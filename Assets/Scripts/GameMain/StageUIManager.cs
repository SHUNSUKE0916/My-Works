using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageUIManager : MonoBehaviour
{
    [SerializeField] GameObject NextStageButton;
    [SerializeField] GameObject ToTitleButton;
    [SerializeField] MainManager mainManager;

    private void Start()
    {
        //HideButton();
    }

    public void HideButton()
    {
        NextStageButton.SetActive(false);
        ToTitleButton.SetActive(false);
    }

    public void ShowButton()
    {
        NextStageButton.SetActive(true);
        ToTitleButton.SetActive(true);
    }

    /*public void NextStage()
    {
        
        mainManager.SceneChange(1);
        
    }

    public void ToTitle()
    {
        mainManager.SceneChange(0);
    }*/
}
