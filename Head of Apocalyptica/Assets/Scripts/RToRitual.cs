using UnityEngine;
using System.Collections;

public class RToRitual : MonoBehaviour
{

    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("win").GetComponent<LevelHandler>().playerDead)
        { 
            if (Input.GetKeyDown(KeyCode.R))
            {
                this.GetComponent<Animator>().Play("Execute");
                this.GetComponent<AudioSource>().Play();
            }
        }
    }
}
