using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Mainmenuscript : MonoBehaviour
{
    public void Play() 
    {
        SceneManager.LoadScene(1);
    }
    public void Exit() 
    {
        Application.Quit();    
    }
}
