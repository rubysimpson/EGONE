using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HeadLevelData : ScriptableObject {

    public HeadVariables[] headLevel;

    [System.Serializable]
    public class HeadVariables
    {
        //variables for level, scale, mass, linear drag
        public int level;
        public Vector3 scale;
        public float mass;
        public float drag;
    }
}
