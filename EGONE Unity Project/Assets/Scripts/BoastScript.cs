using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoastScript : MonoBehaviour {

    public Text boastTextBox;
    public string[] boastPhrases;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if() boastbutton then chck npcproximity
	}

    void CheckNPCProximity()
    {
        //If NPC (check tag) is within x dis of the direction the player is facing the player can boast to them
    }

    void Boast()
    {
        //boast animation
        //boast sound
        //boast bark
        //win or lose
    }

    void BoastBark()
    {
        //select phrase
        //put phrase in textbox
        //delete after x
    }
}
