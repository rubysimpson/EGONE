using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float speed = 10.0f;

    Rigidbody2D RB;

	// Use this for initialization
	void Start () {
        RB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //Move the character along the horrizontal Axis
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

    
		RB.position += Vector2.right * x;
     
	}
}
