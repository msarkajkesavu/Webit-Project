using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderscript : MonoBehaviour
{
    public Transform sp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sp.Translate(Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            sp.Translate(Vector2.left);
        }
    }
}
