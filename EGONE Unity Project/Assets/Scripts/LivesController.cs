using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesController : MonoBehaviour {

    int playerLives = 3;
    public AudioSource deathSound;
    public Text livesDisplay;

    //start void
    void Start()
    {
        livesDisplay.text = "Lives: " + playerLives;
    }

	// Update is called once per frame
	void Update () {
		if(playerLives <= 0)
        {
            Death();
        }
	}

    void Death()
    {
        //play death animation

        //play death sfx
        deathSound.Play();

        //restart at beginning of level
        Restart();
    }

    public void LoseLife()
    {
        playerLives -= 1;
        livesDisplay.text = "Lives: " + playerLives;
    }

    void Restart()
    {
        //player restarts at the start of the level

        //playerLives reset to max
        //playerLives = 3;

        //actually....is there a way to just reload the level from the start? just do that
    }
}