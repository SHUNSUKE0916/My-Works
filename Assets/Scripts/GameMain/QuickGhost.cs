using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickGhost : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject gameOvertext;
    [SerializeField] GameObject Player;


    void Start()
    {
        // playerオブジェクトを取得
        this.player = GameObject.Find("MainPlayer");
        gameOvertext.SetActive(false);
    }

    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        float ENEMY_MOVE_SPEED = 0.08f;
        // プレイヤーの方向に移動させる
        transform.position = Vector3.MoveTowards(transform.position, playerPos, ENEMY_MOVE_SPEED);
    }


    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {

            GameOver();
            Player.SetActive(false);
            SoundManager.instance.StopBGM();
            SoundManager.instance.PlaySE(4);
            yield return new WaitForSeconds(4f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }

    public void GameOver()
    {

        gameOvertext.SetActive(true);
    }


}

