using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // シングルトン
    // ゲーム内に１つしか存在しない物（音を管理する物とか）
    // 利用場所：シーン間でのデータ共有/オブジェクト共有
    // 書き方
    public static SoundManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    //--シングルトン終わり--

    [SerializeField] AudioSource audioSourceBGM;
    [SerializeField] AudioClip[] audioClipsBGM;//(0,タイトル 1,説明 2,ゲーム音楽)
    public AudioSource audioSourceSE;//SEのスピーカー
    public AudioClip[] audioClipsSE;//鳴らす素材

    private void Start()
    {
      
    }

    public void StopBGM()
    {
        audioSourceBGM.Stop();
    }

    public void PlayBGM(string sceneName)
    {
        audioSourceBGM.Stop();
        switch(sceneName)
        {
            default:
            case "TitleScene":
                audioSourceBGM.clip = audioClipsBGM[0];
                break;
            case "Instructions":
                audioSourceBGM.clip = audioClipsBGM[1];
                break;
            case "Stage1":
                audioSourceBGM.clip = audioClipsBGM[2];
                break;
            case "Stage2":
                audioSourceBGM.clip = audioClipsBGM[2];
                break;
            case "Stage3":
                audioSourceBGM.clip = audioClipsBGM[2];
                break;


        }
        audioSourceBGM.Play();
    }

    public void PlaySE(int index)
    {
        audioSourceSE.PlayOneShot(audioClipsSE[index]);//SEを一度だけ鳴らす
    }
}
