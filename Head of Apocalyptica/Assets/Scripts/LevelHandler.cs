using UnityEngine;
using System.Collections;

public class LevelHandler : MonoBehaviour {

    int levelIndex = 0;
    private float playerPosX;
    public GameObject win;

    void Awake() {
        playerPosX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            levelIndex = levelIndex + 1;
            Application.LoadLevel(levelIndex);
        }
    }
	void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}
