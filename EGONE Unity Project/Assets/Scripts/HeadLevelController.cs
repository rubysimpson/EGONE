using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLevelController : MonoBehaviour {

    //reference the headleveldata list
    public HeadLevelData headLevelData;
    public Rigidbody2D rb;

    //the variables

    

	// Use this for initialization
	void Start () {
        //headLevelData.headLevel[0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChangeHeadLevel()
    {
        //rb.mass = mass;
    }

    /*public class HeadVariables
    {
        //variables for level, scale, mass, linear drag
        public int level;
        public Vector3 scale;
        public float mass;
        public float drag;
    }*/
}
