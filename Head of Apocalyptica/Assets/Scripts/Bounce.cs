using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

    public float bounceHeight;
    public float speed;
    private Rigidbody2D rb;
    public AudioClip[] splatSound;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

	void OnCollisionEnter2D(Collision2D coll)
    {
       
        rb.velocity = new Vector2(rb.velocity.x, bounceHeight);
        audio.clip = splatSound[Random.Range(0, splatSound.Length)];
        audio.Play();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "spike")
        {
            Lose();
            GameObject.Destroy(gameObject);
        }
    }
    void Lose()
    {
        FindObjectOfType<Camera>().GetComponent<cameraMove>().cameraSpeed = 0;
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
