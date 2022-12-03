using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementScript : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D MyRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        /*
        //random angle between -80 and 80 to avoid extra waiting time (the ball will go more to the player)
        float angle = Random.Range(-80f, 80f); 
        
        // random +1 or -1 to decide direction of the ball
        float direction = Mathf.Sign(Random.Range(-0.5f, 0.5f)); 
        
        // Convert from polar to cartesian coordinates and multiply by speed and direction
        MyRigidBody.velocity = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * speed * direction; 
        */ //debugging
        MyRigidBody.velocity = Vector2.right;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag){
            case "Wall":
                // if the ball hits the wall, change the direction of the ball
                MyRigidBody.velocity = new Vector2(MyRigidBody.velocity.x, -MyRigidBody.velocity.y);
                break;
            case "Goal":
                // if the ball hits the goal, destroy the ball
                Destroy(gameObject);
                break;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        
        // if the ball hits the player, change the direction of the ball
        if (other.gameObject.CompareTag("Player"))
        {
            MyRigidBody.velocity = new Vector2(-MyRigidBody.velocity.x, MyRigidBody.velocity.y);
        }
    }
}
