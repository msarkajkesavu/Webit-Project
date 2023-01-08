using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1prefab : MonoBehaviour
{
    private Vector2 screenBounds;
 
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("OnCollisionEnter2D");
        //Check to see if the tag on the collider is equal to Enemy
        if (other.gameObject.tag == "web")
        {
            Destroy(other.gameObject);
            
            gameObject.tag = "eatable";
        }
        else if (other.gameObject.tag == "ground") 
        {
            Destroy(this,2);
        }

    }
}
