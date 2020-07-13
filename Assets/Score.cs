using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    GameObject scoreText;//テキスト 

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
            scoreText.GetComponent<scoreScript>().AddScore(10);//コンポーネント取得、引数でポイント
        }
        else if (tag == "LargeStarTag")
        {
            scoreText.GetComponent<scoreScript>().AddScore(20);
        }
        else if (tag == "SmallCloudTag")
        {
            scoreText.GetComponent<scoreScript>().AddScore(40);
        }
        else if (tag == "LargeCloudTag")
        {
            scoreText.GetComponent<scoreScript>().AddScore(60);
        }
        else
        {
            
        }
    }



    
}
