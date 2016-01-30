using UnityEngine;
using System.Collections;

public class assignSprite : MonoBehaviour
    { 
    public Sprite[] sprites;
    private int numberOfSprites;

    void Start()
    {
        numberOfSprites = sprites.Length;
        int stairIndex = Random.Range(0, numberOfSprites);
        GetComponent<SpriteRenderer>().sprite = sprites[stairIndex];
    }
}
