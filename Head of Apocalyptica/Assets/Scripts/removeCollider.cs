using UnityEngine;
using System.Collections;

public class removeCollider : MonoBehaviour {

    private Collider2D myCollider;
    public GameObject bloodSplatter;
    public GameObject head;

    void Start()
    {
        myCollider = GetComponent<Collider2D>();
        head = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        print(head.GetComponent<Transform>().position.x);
    }

	void OnCollisionEnter2D(Collision2D coll)
    {
        myCollider.enabled = !myCollider.enabled;
        Instantiate(bloodSplatter, new Vector3(head.transform.position.x, this.transform.position.y, -1), Quaternion.identity);
    }
}
