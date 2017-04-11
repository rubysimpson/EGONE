using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMotorController : MonoBehaviour {

    public GameObject head;
    HingeJoint2D hinge;

    // Use this for initialization
    void Start ()
    {
        hinge = GetComponent<HingeJoint2D>();
      
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        TiltUp ();
	}

    void TiltUp ()
    {
        //somehow find a way to rotate the head upward
    }

   
}
