using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour {

    public bool beenBoasted = false;
    public HeadLevelController myHead;


    void FacePlayer()
    {
        //if npc is facing away from player when player uses boast function they will turn to face them
    }

    void SitBackDown()
    {
        //play lose boast animation - called when player wins a boast
    }

    void ChangeBeenBoasted()
    {
        beenBoasted = true;
    }
}
