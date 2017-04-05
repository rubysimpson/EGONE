using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour {

    int playerLives = 3;
    public AudioSource deathSound;

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
    }

    public void LoseLife()
    {
        playerLives -= 1;
    }
}