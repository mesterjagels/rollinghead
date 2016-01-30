using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {

    public float cameraSpeed;
    public float speed;

    void Awake()
    {
       
    }
	// Update is called once per frame
	void Update () {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -cameraSpeed);
	}
}
