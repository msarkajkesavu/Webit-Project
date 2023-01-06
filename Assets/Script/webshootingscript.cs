using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webshootingscript : MonoBehaviour
{
    public Transform tr;
    public int speed = 10;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tr.Translate(Vector2.up * speed * Time.deltaTime);
        Destroy(gameObject, time);
    }
}
