using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour {

	public PlayerController playControl;

	void Start(){
		playControl = GameObject.FindGameObjectWithTag ("PlayerBody").GetComponent<PlayerController> (); 
	}

	void Update(){
		LoseControl ();
	}

	public void LoseControl(){
		if (playControl.enabled == false && Input.GetKeyDown(KeyCode.Space)) {
			playControl.enabled = true;
			SceneManager.LoadScene(1);
		}
	}
}