﻿using UnityEngine;
using System.Collections;

public class intro : MonoBehaviour {

	void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Application.LoadLevel(1);
        }
    }
}
