using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementScript : MonoBehaviour
{
    private Rigidbody2D ballRb;
    private Vector2 direction;
    private float ballSpeed = 7f;
    public GameObject heartContainer;
    public LivesControllerScript livesScript;

    // Start is called before the first frame update
    void Start()
    {
        livesScript = heartContainer.GetComponent<LivesControllerScript>();
        ballRb = GetComponent<Rigidbody2D>();
        direction = new Vector2(0.3f, -0.5f) * ballSpeed;
        ballRb.velocity = direction;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3.Reflect(ballRb.velocity, collision.contacts[0].normal);
        Vector3 normal = collision.contacts[0].normal;
        direction = Vector3.Reflect(direction, normal);
        if (collision.gameObject.name == "Paddle")
        {
            ballRb.velocity = Vector3.Normalize(direction + collision.gameObject.GetComponent<Rigidbody2D>().velocity) * ballSpeed;
            direction = ballRb.velocity;
        }
        else if (collision.gameObject.name == "BottomBorder") {
            livesScript.ReduceLife();
            ballRb.velocity = direction;
        }
        else
        {

            ballRb.velocity = direction;
        }
    }
}
