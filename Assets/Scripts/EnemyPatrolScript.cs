using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrolScript : MonoBehaviour
{
    public Transform[] enemyPoints;
    int point = -1;
    Vector2 direction;
    float distance;
    float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        NextPoint();
    }

    // Update is called once per frame
    void Update()
    {
        // move in direction of point
        transform.Translate(direction * speed);

        // find distance between enemy and point
        distance = Vector3.Distance(enemyPoints[point].position, transform.position);

        //Debug.Log("Distance = " + distance);

        if (distance < 0.1) NextPoint();
    }

    void NextPoint()
    {
        if (point < enemyPoints.Length -1)
        {
            point++;
        }
        else
        {
            point = 0;
        }
        

        // find the direction of the next point
        direction = (enemyPoints[point].position - transform.position);

        // cycle through array of points
        
        Debug.Log("Point " + point);
    }
}
