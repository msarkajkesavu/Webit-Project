using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderscript : MonoBehaviour
{
    public Transform spider;
    public Transform webshoot;
    public GameObject webprefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //SpiderMovement Input
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            spider.Translate(Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            spider.Translate(Vector2.left);
        }
        //Webshooting Input
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(webprefab, webshoot,false);
        }
    }
}
