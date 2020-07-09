using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    GameObject scoreText;//テキスト

    int score = 0;//スコア

    

    // Use this for initialization
    void Start () {
        this.scoreText = GameObject.Find("ScoreText");//オブジェクト

    }

    // Update is called once per frame
    void Update () {
    }

    void OnCollisionEnter(Collision other)
    {
        if (tag == "SmallStarTag")
        {
            score += 10;

        }
        else if (tag == "LargeStarTag")
        {
            score += 20;

        }
        else if (tag == "SmallCloudTag")
        {
            score += 50;

        }
        else if (tag == "LargeCloudTag")
        {
            score += 100;
        }
        else
        {
            score += 0;
        }

        this.scoreText.GetComponent<Text>().text = "" + score;//テキスト
    }
}
