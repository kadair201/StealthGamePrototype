using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
    // Variables
    public GameObject player1;
    public GameObject player2;
    float zPos = -10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos1 = player1.transform.position;
        Vector2 pos2 = player2.transform.position;

        Vector2 newPos = (new Vector2((pos1.x + pos2.x)/2, (pos1.y + pos2.y)/2));

        transform.position = new Vector3(newPos.x, newPos.y, zPos);
    }
}
