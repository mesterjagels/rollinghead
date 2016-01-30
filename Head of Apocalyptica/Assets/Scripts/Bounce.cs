using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

    public float bounceHeight;
    public float speed;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void OnCollisionEnter2D(Collision2D coll)
    {
        rb.velocity = new Vector2(rb.velocity.x, bounceHeight);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    rb.AddForce(new Vector2(-speed * transform.position.x, transform.position.y));
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    rb.AddForce(new Vector2(speed * transform.position.x, transform.position.y));
        //}
    }
}
