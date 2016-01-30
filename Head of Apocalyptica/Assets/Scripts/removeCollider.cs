using UnityEngine;
using System.Collections;

public class removeCollider : MonoBehaviour {

    private Collider2D myCollider;

    void Start()
    {
        myCollider = GetComponent<Collider2D>();
    }

	void OnCollisionEnter2D(Collision2D coll)
    {
        myCollider.enabled = !myCollider.enabled;
    }
}
