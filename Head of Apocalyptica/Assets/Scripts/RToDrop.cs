using UnityEngine;
using System.Collections;

public class RToDrop : MonoBehaviour {

	void Update () {
        if (!GameObject.FindGameObjectWithTag("win").GetComponent<LevelHandler>().playerDead)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                this.GetComponent<Animator>().Play("IncaBody");
            }
        }
    }
}
