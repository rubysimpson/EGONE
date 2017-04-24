using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMotorController : MonoBehaviour {

    public Transform head, body;
    public Rigidbody2D hingeRB;
    public HingeJoint2D hinge;
    public float motorSpeedScale = 1;
    public AnimationCurve curve = AnimationCurve.Linear(0,0,1,1);
    
	
	// Update is called once per frame
	void Update ()
    {
        var max = hinge.limits.max;
        var ang = Mathf.Cos(max * Mathf.Deg2Rad);
        var upAng = Vector3.Dot(body.up, head.up);
        upAng = 1 - upAng;
        var torque = upAng / ang ;
        torque = Mathf.Clamp(curve.Evaluate(torque),0,1);

        var leftOrRight = Vector3.Dot(head.transform.up, body.right);

        leftOrRight = leftOrRight > 0 ? 1 : -1;

        torque *= leftOrRight;
        torque *= motorSpeedScale;

        hingeRB.AddTorque(torque, ForceMode2D.Impulse);
        Debug.DrawRay(transform.position, torque * Vector3.right);
    }
}
