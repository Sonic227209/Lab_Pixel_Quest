using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    int varTwo = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float Xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Xinput * speed, rb.velocity.y);
    }
}
