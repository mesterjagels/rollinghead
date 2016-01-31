using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelHandler : MonoBehaviour {

    int levelIndex = 0;
    private float playerPosX;
    public GameObject win;
    public bool levelCompleted;
    public bool playerDead;

    void Awake()
    {
        levelCompleted = false;
        playerDead = false;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        levelCompleted = true;
        playerPosX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        Instantiate(win, new Vector3(playerPosX, transform.position.y + 10.5f, transform.position.z), Quaternion.identity);
    }

    void Update()
    {
        if (levelCompleted) { 
               
            if (Input.GetKey(KeyCode.Space))
            {
                levelIndex = levelIndex + 1;
                Application.LoadLevel(levelIndex);
            }
        } else if (playerDead)
        {
            if (Input.GetKey(KeyCode.R))
            {
                Application.LoadLevel(levelIndex);
            }
        }

    }
}
