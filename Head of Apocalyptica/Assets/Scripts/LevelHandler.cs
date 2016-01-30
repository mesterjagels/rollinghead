using UnityEngine;
using System.Collections;

public class LevelHandler : MonoBehaviour {

    int levelIndex = 0;
    private float playerPosX;
    public GameObject win;

  
    void Update()
    {
        playerPosX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        if (Input.GetKey(KeyCode.Space))
        {
            levelIndex = levelIndex + 1;
            Application.LoadLevel(levelIndex);
        }
    }
	void OnTriggerEnter2D(Collider2D collider)
    {
        playerPosX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        Instantiate(win, new Vector3(playerPosX, transform.position.y + 2, transform.position.z), Quaternion.identity);
    }
}
