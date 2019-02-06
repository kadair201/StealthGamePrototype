using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1Script : MonoBehaviour
{
    /// Variables
    public float force = 2f;
    public Rigidbody2D rb;
    public int playersInTrigger = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0, 1), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector2(0, -1), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2(-1, 0), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EndGameTrigger")
        {
            playersInTrigger++;

            if (playersInTrigger == 2)
            {
                SceneManager.LoadScene("EndScene");
            }
        }
    }
}
