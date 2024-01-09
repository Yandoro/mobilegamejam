using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleMoving : MonoBehaviour
{
    public float speed = 5f;
    public float destroyAfterSeconds = 1f;
    public float reloadTime = 1000f;
    private bool isDead = false;
    void Update()
    {
        if (isDead)
        {
            reloadTime -= 1;
            if (reloadTime <= 0)
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
            }
        }
        Vector2 newPosition = transform.position;
        newPosition.x -= speed * Time.deltaTime;

        transform.position = newPosition;
        
        destroyAfterSeconds -= Time.deltaTime;
        if ( destroyAfterSeconds <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isDead = true;
            Time.timeScale = 0;
            Debug.Log("Spiel pausiert!");
        }
    }
}
