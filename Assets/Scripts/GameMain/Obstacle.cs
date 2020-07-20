using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    [SerializeField] GameObject gameOvertext;
    [SerializeField] GameObject Ghost;
    [SerializeField] GameObject mainPlayer;

    public void Start()
    {
        gameOvertext.SetActive(false);
    }

    IEnumerator OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            GameOver();
            mainPlayer.SetActive(false);
            SoundManager.instance.StopBGM();
            SoundManager.instance.PlaySE(4);
            Destroy(Ghost);
            yield return new WaitForSeconds(4f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void GameOver()
    {
        
        gameOvertext.SetActive(true);
    }
}
