using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEmitter : MonoBehaviour
{

    public GameObject ball;
    public static BallEmitter instance;
    
    void Start()
    {
        EmitBall();
    }
    void Awake()
    {
        instance = this;
    }

    public void EmitBall()
    {
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        direction.Normalize();
        Vector2 position = direction * new Vector2(-5,-5);
        var clone = Instantiate(ball, position, Quaternion.identity, this.transform);
        clone.SetActive(true);
        clone.GetComponent<BallController>().direction = direction;
    }
}
