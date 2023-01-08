using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Mainmenuscript : MonoBehaviour
{
    public GameObject infoui;
    public void Play() 
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("score", 0);
    }
    public void Exit() 
    {
        Application.Quit();    
    }
    public void about() 
    {
        infoui.SetActive(true);
    }
    public void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            infoui.SetActive(false);
        }
            
    }
}
