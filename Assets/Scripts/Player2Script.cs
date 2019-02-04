using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    // Variables
    public float movementSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * movementSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * movementSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * movementSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * movementSpeed);
        }
    }
}
