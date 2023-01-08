using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gameover : MonoBehaviour
{
    public void replay() 
    {
        SceneManager.LoadScene(1);
        
        // Reset the score to 0
        PlayerPrefs.SetInt("score", 0);
    }
    public void menu() 
    {
        SceneManager.LoadScene(0);
        
        PlayerPrefs.SetInt("score", 0);
    }
}
