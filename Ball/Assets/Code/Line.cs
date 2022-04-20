using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed = 15;
    float xDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        if ((transform.position.x <= -9.8 && xDirection < 0) || (transform.position.x >= 9.8 && xDirection >0))
            return;

        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        transform.position = transform.position + new Vector3(moveStep, 0, 0);
    }
}
