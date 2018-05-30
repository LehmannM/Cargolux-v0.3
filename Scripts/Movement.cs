using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple script for movement with keyboard input(Arrowkeys, PageUp, PageDown)

public class Movement : MonoBehaviour {
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))            //Move left
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
		if (Input.GetKeyDown(KeyCode.RightArrow))           //Move right
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))              //Move up
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))            //Move down
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.PageUp))               //Move forward
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.PageDown))             //Move backward
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
	}
}
