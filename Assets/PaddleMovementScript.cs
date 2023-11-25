using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovementScript : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-6, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(6, 0);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);

        }
    }
}
