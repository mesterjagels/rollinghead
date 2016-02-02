using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
    public AudioClip actionMusic;
    public AudioClip suspenseMusic;
    public Text text;
    

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
        camera.GetComponent<AudioSource>().clip = suspenseMusic;
        camera.GetComponent<AudioSource>().Play();
    }

	void OnCollisionEnter2D(Collision2D coll)
    {
        rb.velocity = new Vector2(rb.velocity.x, bounceHeight);
        audio.clip = splatSound[Random.Range(0, splatSound.Length)];
        audio.Play();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "spike" || collider.gameObject.tag == "lava" || collider.gameObject.tag == "hole")
        {
            Lose();
        }
        else if (collider.gameObject.tag == "frog")
            {
            wrongControls = true;
            GameObject.Destroy(collider);
            }
        else if (collider.gameObject.tag == "win")
        {
            FindObjectOfType<Camera>().GetComponent<AudioSource>().Stop();

            FindObjectOfType<Camera>().GetComponent<cameraMove>().cameraSpeed = 0;
            isRolling = !isRolling;

            GameObject.FindGameObjectWithTag("win").GetComponent<LevelHandler>().levelCompleted = true;
            gameObject.SetActive(false);
        }
    }
    public void Lose()
    {
        FindObjectOfType<Camera>().GetComponent<cameraMove>().cameraSpeed = 0;
        isRolling = !isRolling;
        GameObject.FindGameObjectWithTag("win").GetComponent<LevelHandler>().playerDead = true;
        gameObject.SetActive(false);
    }


    void Roll()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            isRolling = !isRolling;
            rb.isKinematic = false;
            canvas.enabled = !canvas.enabled;
            rb.velocity = new Vector2(rb.velocity.x, bounceHeight);
            camera.GetComponent<cameraMove>().cameraSpeed = this.cameraSpeed;
            this.GetComponent<Animator>().Play("RollingHeadAnim");
            camera.GetComponent<AudioSource>().clip = actionMusic;
            camera.GetComponent<AudioSource>().Play();
        }
    }

    void Update()
    {
        if (!isRolling)
        {
            Roll();
        }
        if (isRolling) {
            if (!wrongControls) { 
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    rb.velocity = new Vector2(-speed, rb.velocity.y);
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    rb.velocity = new Vector2(speed, rb.velocity.y);
                }
            } else {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    rb.velocity = new Vector2(speed, rb.velocity.y);
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    rb.velocity = new Vector2(-speed, rb.velocity.y);
                }
            }
        }
    }
}
