using UnityEngine;
using System.Collections;

public class LevelHandler : MonoBehaviour {

    int levelIndex = 0;

	void OnTriggerEnter2D(Collider2D other)
    {
        levelIndex = levelIndex + 1;
        Application.LoadLevel(levelIndex);
       
    }
}
