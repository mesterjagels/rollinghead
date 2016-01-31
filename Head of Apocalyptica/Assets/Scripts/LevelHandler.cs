using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelHandler : MonoBehaviour {

    int levelIndex = 0;
    private float playerPosX;
    public GameObject win;
    public bool levelCompleted;
    public bool playerDead;
    public Text text;
    private Canvas canvas;

    void Awake()
    {
        levelCompleted = false;
        playerDead = false;
        canvas = FindObjectOfType<Canvas>();
    }

    void Update()
    {
        if (levelCompleted) {
            canvas.enabled = true;
               
            if (Input.GetKey(KeyCode.Space))
            {
                print("Change level mofo!");
                levelIndex = levelIndex + 1;
                Application.LoadLevel(levelIndex);
            }
        
        }
    }

	void OnTriggerEnter2D(Collider2D collider)
    {
        levelCompleted = true;
        playerPosX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        Instantiate(win, new Vector3(playerPosX, transform.position.y + 10.5f, transform.position.z), Quaternion.identity);
    }
}
