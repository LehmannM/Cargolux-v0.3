using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple script for rotation with keyboard input (W,A,S,D,Q,E)

public class Rotation : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.A))    //Rotate Left with A 
        {
            transform.Rotate(0, 2, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))    //Rotate Right with D
        {
            transform.Rotate(0, -2, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))    //Rotate Up with W
        {
            transform.Rotate(-2, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))    //Rotate Down with S
        {
            transform.Rotate(2, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Q))    //Rotate Counterclockwise with Q
        {
            transform.Rotate(0, 0, -2);
        }
        if (Input.GetKeyDown(KeyCode.E))    //Rotate Clockwise with E
        {
            transform.Rotate(0, 0, 2);
        }
	}
}
