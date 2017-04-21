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
		WinLoose ();
	}

	public void WinLoose(){
		if (playControl.enabled == false && Input.GetKeyDown(KeyCode.Space))
            // && playerLoose == true //This needs to go into the WinLoose If Statement above so if the player has lost they reload the same level.
        {
            SceneManager.LoadScene(1);
            playControl.enabled = true;
            //This needs to have something that grabs the current scene and loads that.
            
		}
        if (playControl.enabled == false && Input.GetKeyDown(KeyCode.Space))
        // && playerWon == true //This needs to go into the WinLoose If Statement above so if the player has won they load the next level.
        {
            SceneManager.LoadScene(1);
            playControl.enabled = true;
            //This needs to have something that automatically selects the next level based on the current level.
        }

    }
}