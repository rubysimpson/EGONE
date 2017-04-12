using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLevelController : MonoBehaviour {

    //reference the headleveldata list
    public HeadLevelData headLevelData;
    public Rigidbody2D rb;
    public int curLevel;

    //the variables



    // Use this for initialization
    void Start()
    {
        ChangeHeadLevel(curLevel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeHeadLevel(int newLevel)
    {
        var lvlData = headLevelData.headLevel[newLevel];
        curLevel = newLevel;

        transform.localScale = lvlData.scale;

        if (rb != null)
        {
            rb.mass = lvlData.mass;
            rb.drag = lvlData.drag;
        }
    }

    [ContextMenu("GoToNextLevel")]
    public void IncreaseHeadLevel()
    {
        int newLevel = Mathf.Clamp((curLevel + 1), 0, headLevelData.headLevel.Length);
        ChangeHeadLevel(newLevel);
    }

    public void DecreaseHeadLevel()
    {
        int newLevel = Mathf.Clamp((curLevel - 1), 0, headLevelData.headLevel.Length);
        ChangeHeadLevel(newLevel);
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
