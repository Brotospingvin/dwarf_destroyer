using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
<<<<<<< Updated upstream:Assets/player house.cs


    float Speed = 5;
=======
    static int nextScene = 0;
    int score;
    public float Speed = 5;
>>>>>>> Stashed changes:Assets/player.cs
    Rigidbody2D rb;
    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        direction = Vector3.ClampMagnitude(direction, 1);
        direction *= Speed;
        rb.velocity = direction;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        

   
    
        if (collision.gameObject.CompareTag("player"))
        { 
            SceneManager.LoadScene("NEW CRAFTING! I HATE CRAFTING!");
        }

    }
    
}