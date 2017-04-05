using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoastScript : MonoBehaviour {

    public Text boastTextBox;
    public string[] boastPhrases;
    public AudioSource boastSound;
    public Canvas BoastCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if() boastbutton then chck npcproximity
        if (Input.GetKeyDown("space"))
        {
            //CheckNPCProximity();
            BoastBark();
        }
	}

    public void CheckNPCProximity()
    {
        //If NPC (check tag) is within x dis of the direction the player is facing the player can boast to them

    }

    public void Boast()
    {
        //boast animation
        //boast sound
        boastSound.Play(); //i don't know if this will work - doublecheck
        //boast bark
        BoastBark();
        //win or lose
    }

    public void BoastBark()
    {
        //randomly select phrase from boastPhrase array
        int i = Random.Range(0, (boastPhrases.Length));

        //instantiate a new textbox from prefab
        Text newBoast = Instantiate(boastTextBox) as Text;
        newBoast.transform.SetParent(BoastCanvas.transform, false);

        //put phrase in textbox
        newBoast.text = boastPhrases[i]; 

        //delete after x seconds
        Destroy(newBoast, 3);
    }
}
