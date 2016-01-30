using UnityEngine;
using System.Collections;

public class LevelHandler : MonoBehaviour {

    int levelIndex = 0;

	void OnTriggerEnter2D(Collider2D other)
    {
        Application.LoadLevel(levelIndex);
       
    }
}
