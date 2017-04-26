using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoastScript : MonoBehaviour {

    //Bark variables
    public Text boastTextBox;
    public BoastBarkData boastBarkData;
    public Canvas BoastCanvas;

    //Audio variables
    public AudioSource boastSound;
    public AudioSource winBoastSound;
    public AudioSource loseBoastSound;

    //Other GameObjects it impacts
    public LivesController livesController;
    public ScoreController scoreController;

    //list of all npcs in level
    private NPCController[] npcs;
    private NPCController currentTarget;

    public HeadLevelController ourHead;

    public float boastRadius = 5;

    //Particle System
    public ParticleSystem ps;

    void Start()
    {
        npcs = FindObjectsOfType<NPCController>();
      //  ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

        //if() boastbutton then chck npcproximity
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckNPCProximity();

            if (currentTarget != null)
            {
                Boast();
                ParticleSystem();
            }
            // for testing livescontroller -> livesController.LoseLife();

        }
    }

    public void CheckNPCProximity()
    {
        //If NPC (check tag) is within x dis of the direction the player is facing the player can boast to them
        //get someone to help with this probably

        //this needs to be better, it doesn't take into account multiple things being within radius and choosing the best one
        currentTarget = null;

        for (int i = 0; i < npcs.Length; i++)
        {
            //has not been boasted
            if (npcs[i].beenBoasted)
            {
                continue;
            }

            var dif = ourHead.transform.position - npcs[i].transform.position;

            //is within radius
            if (dif.magnitude <= boastRadius)
            {
                currentTarget = npcs[i];
            }
        }
    }

    public void Boast()
    {
        //boast animation

        //boast sound
        boastSound.Play(); //i don't know if this will work - doublecheck

        //boast bark
        BoastBark();

        //we need both the head levels
        var targetHead = currentTarget.myHead;


        //win or lose
        if (ourHead.curLevel > targetHead.curLevel)
        {
            //sendmessage to npc to play npc lose animation
            targetHead.DecreaseHeadLevel();
            ourHead.IncreaseHeadLevel();
            currentTarget.beenBoasted = true;
            //sendmessage to playerHeadLevel to +1
            //sendmessage to scorecontroller to BoastSuccessful()
            scoreController.BoastSuccessful();
            //play player boast win animation

            //play win sfx
            winBoastSound.Play(5); //5 is how long it might take for the initial grunt and animation?
        }
        else
        {
            //send message for player to lose a life
            livesController.LoseLife();

            //play player lose boast animation

            //play player lose sfx
            loseBoastSound.Play(5);
        }
    }

    public void BoastBark()
    {
        //randomly select phrase from boastBarkData's barkList
        int i = Random.Range(0, (boastBarkData.barkList.Length));

        //instantiate a new textbox from prefab
        Text newBoast = Instantiate(boastTextBox) as Text;
        newBoast.transform.SetParent(BoastCanvas.transform, false);

        //put phrase in textbox
        newBoast.text = boastBarkData.barkList[i];

        //delete after x seconds
        Destroy(newBoast, 3);
    }

    public void ParticleSystem()
    {
        ps.Stop();
        ps.Play();
    }

}
