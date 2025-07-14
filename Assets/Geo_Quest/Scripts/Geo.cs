using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geo : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    int varTwo = 3;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        switch (collision.tag)
        {
            case "Win":
                {
                    break;
                }
        }
        // Update is called once per frame
        void Update()
        {
            float Xinput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(Xinput * speed, rb.velocity.y);

            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += new Vector3(0, 1, 0);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += new Vector3(0, -1, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += new Vector3(-1, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += new Vector3(1, 0, 0);
            }
        }

    }
}
     