using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMotorController : MonoBehaviour {

    public GameObject head;
    HingeJoint2D HJ;

	// Use this for initialization
	void Start () {
        HJ = GetComponent<HingeJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
