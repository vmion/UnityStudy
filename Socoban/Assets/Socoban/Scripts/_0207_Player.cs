using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0207_Player : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody playerRigidbody;
    public GameManager gameManager;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if(gameManager.isGameOver == true)
        {
            return;
        }
        /*
        if(Input.GetKey(KeyCode.W))
        {
            playerRigidbody.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRigidbody.AddForce(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigidbody.AddForce(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRigidbody.AddForce(speed, 0, 0);
        }
        */
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float fallSpeed = playerRigidbody.velocity.y;
        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed;
        velocity.y = fallSpeed;
        playerRigidbody.velocity = velocity;
    }
}
