using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background: MonoBehaviour
{
    private float moveSpeed = 1f;    

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < -238)
        {
            transform.position += new Vector3(-265f, 0, 0);
        }
    }
}
