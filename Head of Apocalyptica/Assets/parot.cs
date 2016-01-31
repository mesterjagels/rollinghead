using UnityEngine;
using System.Collections;

public class parot : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;
    public GameObject player;
	// Update is called once per frame

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
        if (collider.gameObject.tag == "Player") { 
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * 2, player.GetComponent<Rigidbody2D>().velocity.y);
    }
    }
}
