using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoving : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x -= speed * Time.deltaTime; 

        transform.position = newPosition;
    }
}
