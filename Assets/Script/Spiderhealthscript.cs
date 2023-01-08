using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spiderhealthscript : MonoBehaviour
{
    public Image healthslider;
    public int health = 120;
    // Update is called once per frame
    void Update()
    {
        healthslider.rectTransform.sizeDelta = new Vector2(health, 10);
        if (health > 120) 
        {
            health = 120;
        }
    }
}
