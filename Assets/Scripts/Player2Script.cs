using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    // Variables
    public float force = 2f;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector2(0,1), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector2(0, -1), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-1,0), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
