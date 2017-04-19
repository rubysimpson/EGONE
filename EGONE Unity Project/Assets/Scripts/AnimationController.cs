using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

	public bool IsMoving;
	public bool BoastWin;
	public bool BoastFail;
	public bool Idle;
	
	// Update is called once per frame
	void Update () {
		
	}

	void Animation(){
		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.D))
			IsMoving = true;
		if (Input.GetKeyDown(KeyCode.Space))
			BoastWin = true;
	}
}
