using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stage2toStage3 : MonoBehaviour
{

    [SerializeField] string[] sceneName;
    [SerializeField] StageUIManager StageUIManager;
    [SerializeField] GameObject NextStageButton;
    [SerializeField] GameObject ToTitleButton;


    private void Start()
    {
        StageUIManager.HideButton();
    }


    public void SceneChange(int index)
    {
        SceneManager.LoadSceneAsync(sceneName[index]);
    }

    public void NextStage()
    {
        SoundManager.instance.PlaySE(2);
        SceneChange(1);

    }

    public void ToTitle()
    {
        SoundManager.instance.PlaySE(2);
        SceneChange(0);
    }
}