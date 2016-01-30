using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

    public float bounceHeight = 1;
    public float speed = 1;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void OnCollisionEnter2D(Collision2D coll)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, bounceHeight);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, this.GetComponent<Rigidbody2D>().velocity.y);
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
