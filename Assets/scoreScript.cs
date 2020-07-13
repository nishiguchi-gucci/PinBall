using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour {
    public Text scoreText;
    private int score = 0; //スコア計算用変数

    void Start()
    {
        score = 0;
        scoreText.text = string.Format("Score:{0}", score);
    }

    public void AddScore(int point)
    {
        score += point;

        scoreText.text = string.Format("Score:{0}", score);
    }
}
