using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1spawn : MonoBehaviour
{
    public GameObject Enemy1Prefab;
    public float respawnTime = 0.2f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(enemyWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(Enemy1Prefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y + 5 );
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
