using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

    public float bounceHeight;
    public float speed;
    private Rigidbody2D rb;
    public AudioClip[] splatSound;
    private AudioSource audio;
    public bool isRolling = false;
    private Camera camera;
    public float cameraSpeed;
    public Canvas canvas;

    private bool wrongControls = false;
    

    void Awake()
    {
        canvas = FindObjectOfType<Canvas>();
        audio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        camera = FindObjectOfType<Camera>();

        rb.isKinematic = true;
        canvas.enabled = true;        
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
        else if (collider.gameObject.tag == "frog")
            {
            wrongControls = true;
            GameObject.Destroy(collider);
            }
        else if (collider.gameObject.tag == "win")
        {
            Lose();
            GameObject.Destroy(gameObject);
        }
    }
    public void Lose()
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
                canvas.enabled = !canvas.enabled;
                rb.velocity = new Vector2(rb.velocity.x, bounceHeight);
                camera.GetComponent<cameraMove>().cameraSpeed = this.cameraSpeed;
                this.GetComponent<Animator>().Play("RollingHeadAnim");  
            }
        }
        if (isRolling) {
            if (!wrongControls) { 
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    rb.velocity = new Vector2(-speed, rb.velocity.y);
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    rb.velocity = new Vector2(speed, rb.velocity.y);
                }
            } else {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    rb.velocity = new Vector2(speed, rb.velocity.y);
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    rb.velocity = new Vector2(-speed, rb.velocity.y);
                }
            }
        }
    }
}
