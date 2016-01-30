using UnityEngine;
using System.Collections;

public class RToDrop : MonoBehaviour {

	void Update () {
        if (!GameObject.FindGameObjectWithTag("Player").GetComponent<Bounce>().isRolling)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                this.GetComponent<Animator>().Play("IncaBody");
            }
        }
    }
}
