using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class SpikeAnimation : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player") { 
            GetComponent<Animator>().Play("SpikeDeath");
            GetComponent<AudioSource>().Play();
     }
    }
}
