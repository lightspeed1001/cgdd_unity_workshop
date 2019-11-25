using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public int highScore;
    private int ballCount = 1;
    private bool spawnedBall = false;
    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if(score > 1 && score % 10 == 0)
        {
            if(!spawnedBall)
            {
                spawnedBall = true;
                BallEmitter.instance.EmitBall();
                ballCount++;
            }
        }
        else
            spawnedBall = false;
    }

    public void BallDied()
    {
        ballCount--;
        if(ballCount == 0)
        {
            if(score > highScore)
                highScore = score;
            score = 0;
            BallEmitter.instance.EmitBall();
            ballCount++;
        }
    }
}
