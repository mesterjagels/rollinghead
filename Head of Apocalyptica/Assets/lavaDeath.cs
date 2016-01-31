using UnityEngine;
using System.Collections;

public class lavaDeath : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
            GetComponent<AudioSource>().Play();
    }
}
