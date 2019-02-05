using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D rb;
    bool canMoveDown = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 20) canMoveDown = true;
        if (transform.position.y <= 10) canMoveDown = false;

        if (canMoveDown)
        {
            rb.AddForce(new Vector2(0, -1), ForceMode2D.Impulse);
        }
        
        if (!canMoveDown)
        {
            rb.AddForce(new Vector2(0, 1), ForceMode2D.Impulse);
        }
    }
}
