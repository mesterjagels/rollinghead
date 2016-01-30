using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

    public float bounceHeight;
    public float speed;
    private Rigidbody2D rb;
    public AudioClip[] splatSound;
    private AudioSource audio;
    private bool isRolling = false;
    private Camera camera;
    public float cameraSpeed;
    

    void Awake()
    {
        audio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        camera = FindObjectOfType<Camera>();
        camera.GetComponent<cameraMove>().cameraSpeed = 0;
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
        if (!isRolling)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                isRolling = !isRolling;
                rb.isKinematic = false;
                rb.velocity = new Vector2(rb.velocity.x, bounceHeight);
                camera.GetComponent<cameraMove>().cameraSpeed = this.cameraSpeed;
                this.GetComponent<Animator>().Play("RollingHeadAnim");  
            }
        }
        if (isRolling) { 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
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
