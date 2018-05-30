using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple script to scale the object with keyboard input (R, F)

public class Scaling : MonoBehaviour {
	
	void Update () {
       
        if (Input.GetKeyDown(KeyCode.R))                            //Scale up
        {
            transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
        }
        if (Input.GetKeyDown(KeyCode.F))                            //Scale down
        {
            transform.localScale -= new Vector3(0.1F, 0.1F, 0.1F);
        }
	}
}
