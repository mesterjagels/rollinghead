using UnityEngine;
using System.Collections;

public class HoleDeath : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Animator>().Play("HoleDeathAnim");
        }
    }
}
