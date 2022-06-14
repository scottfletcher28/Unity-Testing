using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public Rigidbody2D rb;
    public float jumpheight = 1;
    public float speed = 1;
    
    void Update()
    {
        if (Input.GetKey("space"))

        {
            rb.AddForce(Vector2.up * jumpheight, ForceMode2D.Impulse);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);

        }
    }
}
