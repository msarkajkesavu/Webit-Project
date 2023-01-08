using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1prefab : MonoBehaviour
{
    private Vector2 screenBounds;
    private Animator anime;


    void Start()
    {
        anime = GetComponent<Animator>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "web" && this.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            anime.SetBool("enemy1caught", true);
            anime.SetBool("enemyground", false);
            gameObject.tag = "eatable";
        }
        else if (other.gameObject.tag == "Ground" && this.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject, 2);
        }
        else if (other.gameObject.tag == "Ground" && this.gameObject.tag == "eatable")
        {
            anime.SetBool("enemyground", true);
            anime.SetBool("enemy1caught", false);
        }




    }
}
