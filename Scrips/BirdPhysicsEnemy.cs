using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class BirdPhysicsEnemy : MonoBehaviour
{
    public float speed = 2;
    public float force = 2;
    public float attackDamage = 1;

    private Transform bird;
    private bool ataca = false;

    void Start()
    {

        Rigidbody2D birdEnemy = GetComponent<Rigidbody2D>();
        birdEnemy.velocity = Vector2.left * speed;



    }

    void Update()
    {
        if (ataca)
        {

            Vector2 newVelocity = Vector2.right * speed;
            Rigidbody2D birdBody = GetComponent<Rigidbody2D>();
            birdBody.velocity = newVelocity;

            ataca = true;
            CircleCollider2D birdE = GetComponent<CircleCollider2D>();
            
        }

        else
        {

            if (!ataca)
            {

                Vector2 newVelocity = Vector2.left * speed;
                Rigidbody2D birdBody = GetComponent<Rigidbody2D>();
                birdBody.velocity = newVelocity;

                ataca = false;
                CircleCollider2D birdE = GetComponent<CircleCollider2D>();
                
            }
        }
    }
}
    