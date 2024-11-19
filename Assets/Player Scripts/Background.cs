using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Background: MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 8f;    

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Backgrund")
        {
            transform.position = new Vector3(15.3f, 0, 0);
        }
    }

}
