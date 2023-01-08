using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorecounter : MonoBehaviour
{
    public int score = 0;
    

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "web")
        {
            score += 1;
        }
    }
}
