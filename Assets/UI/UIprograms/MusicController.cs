using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicController : MonoBehaviour
{
     static public MusicController instance;

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
    //シングルトン設定ここまで




    public AudioSource A_BGM;//AudioSource型の変数A_BGMを宣言　対応するAudioSourceコンポーネントをアタッチ
    public AudioSource B_BGM;//AudioSource型の変数B_BGMを宣言　対応するAudioSourceコンポーネントをアタッチ

    private string beforeScene;//string型の変数beforeSceneを宣言 
        
    void Start()
    {
        beforeScene = "Title";//起動時のシーン名 を代入しておく
        A_BGM.Play();//A_BGMのAudioSourceコンポーネントに割り当てたAudioClipを再生

        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    
    

    //シーンが切り替わった時に呼ばれるメソッド　
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {      
            //シーンがどう変わったかで判定
            //Scene1からScene2へ
            if (beforeScene == "Title" && nextScene.name == "Main")
            {
              A_BGM.Stop();
              B_BGM.Play();
            }

            // Scene1からScene2へ
             if (beforeScene == "Main" && nextScene.name == "Title")
             {
              A_BGM.Play();
              B_BGM.Stop();
             }         
    }
}
