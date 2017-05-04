using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class HitDetection : MonoBehaviour {

	public Canvas LoseCanvas;
    public Canvas WinCanvas;
    public PlayerController playControl;
    public bool playerWon;
    public bool playerLoose;
    //array of all the sounds played when the player dies
    public AudioClip[] failSounds;
    //array of all the sounds played when the player dies
    public AudioClip[] winSounds;

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
            FindObjectOfType<LoseScreen>().enabled = true;
			LoseCanvas.enabled = true;
            PlayRandomFailSound();
            //insert lose audio
            playControl.enabled = false;
            playerLoose = true;
            //This needs to link to the "LoseScreen" Script somehow so it can get the "playerLoose" information
        }
        if (other.gameObject.tag == "EndZone")
        {
            FindObjectOfType<WinScreen>().enabled = true;
            WinCanvas.enabled = true;
            PlayRandomWinSound();
            //insert lose audio
            playControl.enabled = false;
            playerWon = true;
            //This needs to link to the "LoseScreen" Script somehow so it can get the "playerWon" information
        }

    }
    public void PlayRandomFailSound()
    {
        // Random Selected Number
        int randomClip = Random.Range(0, failSounds.Length);
        AudioSource source = gameObject.AddComponent<AudioSource>();
        source.clip = failSounds[randomClip];
        source.Play();
        Destroy(source, failSounds[randomClip].length);
    }

    public void PlayRandomWinSound()
    {
        // Random Selected Number
        int randomClip = Random.Range(0, winSounds.Length);
        AudioSource source = gameObject.AddComponent<AudioSource>();
        source.clip = winSounds[randomClip];
        source.Play();
        Destroy(source, winSounds[randomClip].length);
    }
}
