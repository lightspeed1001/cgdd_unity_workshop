using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float rotationSpeed;
    public int rotationDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationDirection = Input.GetMouseButton(0) ? 1 : Input.GetMouseButton(1) ? -1 : 0;
    }

    void FixedUpdate()
    {
        if(rotationDirection != 0)
            transform.Rotate(0, 0, rotationSpeed * Time.fixedDeltaTime * rotationDirection);
    }
}
