using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderscript : MonoBehaviour
{
    private Transform spider;
    public Transform webshoot;
    public GameObject webprefab;
    private Animator spanime;
    public int webspeed,destroytime;
    
    // Start is called before the first frame update
    void Start()
    {
        spanime = GetComponent<Animator>();
        spider = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        spidermovement();
        webshooting();
        
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

        }
        else
        {
            //Otherwise default animation 
            spanime.SetBool("isshoot", false);
        }
        
    }
}
