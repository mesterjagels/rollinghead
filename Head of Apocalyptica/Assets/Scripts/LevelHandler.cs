using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelHandler : MonoBehaviour {

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
                Application.LoadLevel(Application.loadedLevel + 1);
            }
        } else if (playerDead)
        {
            if (Input.GetKey(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }

    }
}
