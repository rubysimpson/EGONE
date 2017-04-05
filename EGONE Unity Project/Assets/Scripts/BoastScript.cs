using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoastScript : MonoBehaviour {

    //Bark variables
    public Text boastTextBox;
    public string[] boastPhrases;
    public Canvas BoastCanvas;

    //Audio variables
    public AudioSource boastSound;
    public AudioSource winBoastSound;
    public AudioSource loseBoastSound;

	// Update is called once per frame
	void Update () {
        //if() boastbutton then chck npcproximity
        if (Input.GetKeyDown("space"))
        {
            //CheckNPCProximity();
            Boast();
        }
	}

    public void CheckNPCProximity()
    {
        //If NPC (check tag) is within x dis of the direction the player is facing the player can boast to them
        //get someone to help with this probably
    }

    public void Boast()
    {
        //boast animation

        //boast sound
        boastSound.Play(); //i don't know if this will work - doublecheck
        
        //boast bark
        BoastBark();
        
        //win or lose
        /*if(playerHeadLevel? > NPCHeadLevel)
        {
            //sendmessage to npc to play npc lose animation
            //sendmessage to playerHeadLevel to +1
            //play player boast win animation
            
            //play win sfx
            winBoastSound.Play(5); //5 is how long it might take for the initial grunt and animation?
        }
        else{
            //send message for player to lose a life
            //play player lose boast animation
            //play player lose sfx
            loseBoastSound.Play(5);
        }*/
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
