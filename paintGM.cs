using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;
using UnityEngine.UI;



public class paintGM : MonoBehaviour {
	
	public Transform baseDot;
	//public KeyCode mouseLeft;
	public static string toolType;
	public GazePoint gPoint;

	//public static Color currentColor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (TobiiAPI.GetGazePoint ().PreciseTimestamp > 5) {
			 gPoint = TobiiAPI.GetGazePoint ();
			 
		}
		Vector2 mousePosition = gPoint.Screen;
		Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

//		 if (Input.GetKey (mouseLeft)) {
			Instantiate (baseDot, objPosition, baseDot.rotation);
//		}
	}
}
