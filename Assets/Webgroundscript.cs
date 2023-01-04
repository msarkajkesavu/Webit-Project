using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webgroundscript : MonoBehaviour
{
    public Rigidbody2D web;
    int hit = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (hit == 5)
        {

            Debug.Log("Max webstring capacity" + hit + "Game Over");

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Webstring capacity - "+ hit);
            hit += 1;
        }
    }

}
