using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public Text scoreBox;
    int NPCsBoasted = 0;
    string NPCsInLevel = "/5";
    // Use this for initialization
    void Start()
    {
        scoreBox.text = NPCsBoasted + NPCsInLevel; //initialising scorebox display
    }

    public void BoastSuccessful() //called when player wins a boast
    {
        NPCsBoasted += 1;
        scoreBox.text = NPCsBoasted + NPCsInLevel;
    }
}
