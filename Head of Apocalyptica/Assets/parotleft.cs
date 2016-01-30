using UnityEngine;
using System.Collections;

public class parotleft : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    // Update is called once per frame

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    void Update()
    {
        if (transform.position.x > 12f)
        {
            transform.position = new Vector2(-12f, transform.position.y);
        }
    }
}
