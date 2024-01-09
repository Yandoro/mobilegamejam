using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoving : MonoBehaviour
{
    public float speed = 5f;
    public float destroyAfterSeconds = 1f;
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x -= speed * Time.deltaTime; 

        transform.position = newPosition;

        destroyAfterSeconds -= Time.deltaTime;
        if ( destroyAfterSeconds <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
