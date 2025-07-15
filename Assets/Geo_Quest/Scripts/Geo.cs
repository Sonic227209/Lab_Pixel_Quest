using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geo : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    int varTwo = 3;
    public string nextLevel = "Scene_2";


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        switch (collision.tag)
        {
            case "Respawn":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
       

    }
    // Update is called once per frame
    void Update()
    {
        float Xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Xinput * speed, rb.velocity.y);


    }



}
     