using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webgroundscript : MonoBehaviour
{
    public Rigidbody2D web;
    public BoxCollider2D col;
    int hit = 0,destroytime = 2;
    private Animator webstringanime;
    public GameObject gameoverui;
    // Start is called before the first frame update
    void Start()
    {
        webstringanime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (hit >= 5)
        {

            
            col.enabled = false;
            webstringanime.SetBool("gameover", true);
            gameoverui.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Webstring capacity - "+ hit);
            hit += 1;
        }
        if (collision.gameObject.CompareTag("eatable"))
        {
            GameObject.Destroy(collision.gameObject, destroytime);
        }
    }

}
