using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy_Bird_Script : MonoBehaviour
{

    public Rigidbody2D rb;
    [SerializeField]
    float speed;
    public Game_Manager game_Manager;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector3.up * speed;  
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        game_Manager.GameOver();
    }
}
