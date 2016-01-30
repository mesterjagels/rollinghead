using UnityEngine;
using System.Collections;

public class parot : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;
	// Update is called once per frame

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
	void Update () {
	    if(transform.position.x < -10f)
        {
            transform.position = new Vector2(12f, transform.position.y);
        }
	}
    void OnTriggerEnter2D(Collider2D collider)
    {
        collider.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * 2, collider.GetComponent<Rigidbody2D>().velocity.y);
    }
}
