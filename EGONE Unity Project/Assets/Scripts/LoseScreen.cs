using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour {

	public PlayerController playControl;

	void Start(){
		playControl = GameObject.FindGameObjectWithTag ("PlayerBody").GetComponent<PlayerController> (); 
	}

	public void ReloadScene(){
		playControl.enabled = false;
		SceneManager.LoadScene(1);
	}
}