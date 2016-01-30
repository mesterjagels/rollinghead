using UnityEngine;
using System.Collections;

public class SpikeAnimation : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider)
    {
        GetComponent<Animator>().Play("SpikeDeath");
        GetComponent<AudioSource>().Play();
    }
}
