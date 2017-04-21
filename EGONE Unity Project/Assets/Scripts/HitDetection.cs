using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour {

	public Canvas LoseCanvas;
    public Canvas WinCanvas;
    public PlayerController playControl;
    public bool playerWon;
    public bool playerLoose;

	void Start(){
		LoseCanvas.enabled = false;
        WinCanvas.enabled = false;
        playerWon = false;
        playerLoose = false;
        playControl = GameObject.FindGameObjectWithTag ("PlayerBody").GetComponent<PlayerController> ();  
	}

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Ground")
        {
			LoseCanvas.enabled = true;
			//insert lose audio
			playControl.enabled = false;
            playerLoose = true;
            //This needs to link to the "LoseScreen" Script somehow so it can get the "playerLoose" information
        }
        if (other.gameObject.tag == "EndZone")
        {
            WinCanvas.enabled = true;
            //insert lose audio
            playControl.enabled = false;
            playerWon = true;
            //This needs to link to the "LoseScreen" Script somehow so it can get the "playerWon" information
        }

    }
}
