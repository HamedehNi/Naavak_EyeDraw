using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;

public class dotcontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GetComponent<SpriteRenderer> ().color = paintGM.currentColor;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseOver(){
		if (paintGM.toolType == "eraser") {
			Destroy (gameObject);
		}
	}
}
