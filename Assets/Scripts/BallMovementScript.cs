using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementScript : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)) * speed; // Randomize the direction of the ball);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
