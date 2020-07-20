using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour

    
{
    [SerializeField] StageUIManager StageUIManager;
    MainManager mainManager;
    [SerializeField] GameObject ghost;
    [SerializeField] GameObject ghost2;
    [SerializeField] GameObject mainPlayer;
    private void Start()
    {
       // mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            mainPlayer.SetActive(false);
            // mainManager.SceneChange(0);
            StageUIManager.ShowButton();
            Destroy(ghost);
            Destroy(ghost2);
            SoundManager.instance.PlaySE(3);
            SoundManager.instance.StopBGM();


        }
    }
}
