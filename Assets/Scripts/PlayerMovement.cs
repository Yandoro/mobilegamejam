using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    Vector2 vec;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

 
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            
            
            if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(0).phase == TouchPhase.Stationary)
            {
                vec = Input.GetTouch(0).position;
                
                rb.position = Camera.main.ScreenToWorldPoint(vec);
            }

        }
    }
}
