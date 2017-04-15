using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

	public Canvas LoseCanvas;
	public PlayerController playControl;

	void Start(){
		LoseCanvas.enabled = false;
		playControl = GameObject.FindGameObjectWithTag ("PlayerBody").GetComponent<PlayerController> ();  
	}

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Ground")
        {
			LoseCanvas.enabled = true;
			//insert lose audio
			playControl.enabled = false;
        }
       
    }
}
