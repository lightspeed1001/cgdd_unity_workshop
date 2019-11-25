using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreLabel;
    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = string.Format("High Score: {0,2}\nScore: {1,2}", GameManager.instance.highScore, GameManager.instance.score);
    }
}
