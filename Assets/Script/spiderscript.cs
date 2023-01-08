using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spiderscript : MonoBehaviour
{
    private Transform spider;
    public Transform webshoot;
    public GameObject webprefab,Gameoverui;
    private Animator spanime;
    public int webspeed, destroytime, eaten=1;
    private int webs = 0, shooted=0;

    //private Spiderhealthscript spiderhp;
    public Image healthslider;
    public int health = 120;

    // Start is called before the first frame update
    void Start()
    {
        spanime = GetComponent<Animator>();
        spider = GetComponent<Transform>();
        //spiderhp = GetComponent<Spiderhealthscript>();
    }

    // Update is called once per frame
    void Update()
    {
        spidermovement();
        webshooting();
        healthsystem();
    }
    void spidermovement()
    {
        //SpiderMovement Input
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Move the spider right & set the bool true 
            spider.Translate(Vector2.right);
            spanime.SetBool("ismove", true);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Move the spider left & set animation bool true
            spider.Translate(Vector2.left);
            spanime.SetBool("ismove", true);
        }
        else
        {   //Otherwise default animation 
            spanime.SetBool("ismove", false);
        }
    }
    void webshooting() 
    {
        //Webshooting Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Spawing the web ,adding velocity, destroy after t time and animation bool set to ture
            GameObject web = Instantiate(webprefab, webshoot.position,Quaternion.identity);
            Rigidbody2D webrb = web.GetComponent<Rigidbody2D>();
            webrb.velocity = new Vector2(0, webspeed);
            GameObject.Destroy(web, destroytime);
            spanime.SetBool("isshoot", true);
            webs = webs + 1;

        }
        else
        {
            //Otherwise default animation 
            spanime.SetBool("isshoot", false);
        }
        
    }
    void healthsystem() 
    {
        if(webs > 5) 
        {
            health = health - 30;
            webs = 0;
        }
        healthslider.rectTransform.sizeDelta = new Vector2(health, 10);
        if (health > 120)
        {
            health = 120;
        }
        else if(health == 0) 
        {
            Gameoverui.SetActive(true);
            Time.timeScale = 0f;
        }
        //increass and decress health value here and update to the spiderhealthscript
        //use spiderhp.health for assigning values
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy") 
        {
            health -= 10;
        }
        else if(collision.gameObject.tag == "eatable") 
        {
            health += 10;
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.AddScore(1);
            Destroy(collision.gameObject);
            
        }
    }
    
}
