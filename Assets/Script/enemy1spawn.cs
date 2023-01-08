using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1spawn : MonoBehaviour
{
    public GameObject Enemy1Prefab;
    public int respawnTime = 5;
    public int enemyspeed = 1;
    private Vector2 screenBounds;
    ScoreManager scoreManager;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(enemyWave());
        scoreManager = GetComponent<ScoreManager>();
    }
    void Update()
    {//Incress wave speed by one
        int score = scoreManager.score;
        if(score > 0 && score < 30) 
        {
            respawnTime = 5;
        }
        else if (score > 30 && score < 50)
        {
            respawnTime = 2;
        }
        else if (score > 50 && score < 100)
        {
            respawnTime = 3;
        }
        else if (score > 100)
        {
            respawnTime = 1;
        }

    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(Enemy1Prefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y + 5 );
        Rigidbody2D enemy = a.GetComponent<Rigidbody2D>();
        enemy.velocity = new Vector2(0, -enemyspeed);
    }
    IEnumerator enemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
