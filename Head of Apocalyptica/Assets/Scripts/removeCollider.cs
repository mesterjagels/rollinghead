using UnityEngine;
using System.Collections;

public class removeCollider : MonoBehaviour {

    private Collider2D myCollider;

    public Sprite[] sprites;
    private int numberOfSprites;

    void Start()
    {
        numberOfSprites = sprites.Length;
        int stairIndex = Random.Range(0, numberOfSprites);
        GetComponent<SpriteRenderer>().sprite = sprites[numberOfSprites];
        myCollider = GetComponent<Collider2D>();
    }

	void OnCollisionEnter2D(Collision2D coll)
    {
        myCollider.enabled = !myCollider.enabled;
    }
}
