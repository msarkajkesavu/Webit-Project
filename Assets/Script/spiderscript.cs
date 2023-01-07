using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderscript : MonoBehaviour
{
    public Transform spider;
    public Transform webshoot;
    public GameObject webprefab;
    private Animator spanime;
    // Start is called before the first frame update
    void Start()
    {
        spanime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //SpiderMovement Input
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            spider.Translate(Vector2.right);
            spanime.SetBool("ismove", true);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            spider.Translate(Vector2.left);
            spanime.SetBool("ismove", true);
        }
        else 
        {
            spanime.SetBool("ismove", false);
        }
        //Webshooting Input
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(webprefab, webshoot,false);
            spanime.SetBool("isshoot", true);
            
        }
        else 
        {
            spanime.SetBool("isshoot", false);
        }
    }
}
