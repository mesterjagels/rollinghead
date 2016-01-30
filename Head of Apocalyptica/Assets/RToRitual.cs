using UnityEngine;
using System.Collections;

public class RToRitual : MonoBehaviour
{

    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("Player").GetComponent<Bounce>().isRolling)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                this.GetComponent<Animator>().Play("Execute");
                this.GetComponent<AudioSource>().Play();
            }
        }
    }
}
