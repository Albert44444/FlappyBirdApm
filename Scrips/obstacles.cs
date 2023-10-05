using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public float speed = 0;
    // Start is called before the first frame update
    public float tempsentrereversa = 0;
    void Start()
    {
        Rigidbody2D obstacleRigidbody = GetComponent<Rigidbody2D>();
        obstacleRigidbody.velocity = Vector2.up * speed;

        InvokeRepeating("Reverse",0,tempsentrereversa);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Reverse()
    {
        Rigidbody2D obstacleRigidbody = GetComponent<Rigidbody2D>();
        obstacleRigidbody.velocity *= -1;
    }
}
