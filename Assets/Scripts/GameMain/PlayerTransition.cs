using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransition : MonoBehaviour
{
   [SerializeField] float speed = 100f;    // 移動早さ

    Animator animator;
    Vector2 direction;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerIDOU();
    }

    public void PlayerIDOU()
    {
        
        // 矢印キーの入力情報を取得
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 移動する向きを作成する
        direction = new Vector2(h, v).normalized;

        // 移動する向きとスピードを代入 
        GetComponent<Rigidbody2D>().velocity = direction * speed;

        animator.SetFloat("D_X", h);
        animator.SetFloat("D_Y", v);


    }

  

}
