using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRanking : MonoBehaviour
{
    string[] rank = {"1st","2nd","3rd"};
    int[] ranking = {0,0,0};
    public Text[] rankingText=new Text[3];

    // Start is called before the first frame update
    void Start()
    {
        GetRanking();
        SetRanking(GameController.Score.score);
        for (int i = 0; i < rankingText.Length; i++)
        {
            rankingText[i].text = ranking[i].ToString();
        }
        GameController.Score.score=0;

    
    }
    void SetRanking(int score)
    {
        for(int i=0;i<ranking.Length;i++)
        {
            if(score>ranking[i])
            {
                var change = ranking[i];
                ranking[i] = score;
                score = change; 
            }
        }
        for (int i = 0; i < ranking.Length; i++)
        {
            PlayerPrefs.SetInt(rank[i],ranking[i]);
        }
    }
    void GetRanking()
    {
        for (int i = 0; i < ranking.Length; i++)
        {
            ranking[i]=PlayerPrefs.GetInt(rank[i]);
        }
    }

}
