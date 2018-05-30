﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClampName : MonoBehaviour {

    public Transform target;
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        target.transform.position = namePos;
	}
}
