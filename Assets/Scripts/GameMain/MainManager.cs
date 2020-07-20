using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainManager : MonoBehaviour
{
    
    [SerializeField] string[] sceneName;
    [SerializeField] StageUIManager StageUI;
    [SerializeField] GameObject NextStageButton;
    [SerializeField] GameObject ToTitleButton;
   


    private void Start()
    {
        //DontDestroyOnLoad(gameObject);
        StageUI.HideButton();
        SoundManager.instance.PlayBGM("Stage2");
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
