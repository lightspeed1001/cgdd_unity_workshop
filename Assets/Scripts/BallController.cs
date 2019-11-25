﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D body;
    public Vector2 direction;
    public float impulse;
    public Vector2 levelBounds;
    // Start is called before the first frame update
    void Start()
    {
        body.velocity = direction.normalized * impulse;
    }

    // Update is called once per frame
    void Update()
    {
        float ballAngle = Vector2.Angle(transform.position, body.velocity);
        if(ballAngle < 90 && 
            (transform.position.x < -levelBounds.x ||
            transform.position.x > levelBounds.x ||
            transform.position.y < -levelBounds.y ||
            transform.position.y > levelBounds.y))
        {
            // Reset();
            GameManager.instance.BallDied();
            Destroy(gameObject);
        }
    }
}
