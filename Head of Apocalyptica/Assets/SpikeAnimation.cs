using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class SpikeAnimation : MonoBehaviour {
    public GameObject text;
    private Canvas canvas;

	void OnTriggerEnter2D(Collider2D collider)
    {
        GetComponent<Animator>().Play("SpikeDeath");
        GetComponent<AudioSource>().Play();
        text.GetComponent<Text>().text = "Press 'R' to Restart";
    }
}
