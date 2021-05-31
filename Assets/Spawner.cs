using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Wave> waves;
    int currentWaveIdx = 0;
    int nextSpawnIdx = 0;
    float timeSinceSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
        timeSinceSpawn += Time.deltaTime;
        Wave currentWave = waves[currentWaveIdx];
        if (nextSpawnIdx < currentWave.enemies.Count) {
            if (timeSinceSpawn > currentWave.delayBetweenSpawns[nextSpawnIdx]) {
                // spawn enemy
                Instantiate(currentWave.enemies[nextSpawnIdx], transform.position, Quaternion.identity);
                nextSpawnIdx++;
                timeSinceSpawn = 0.0f;
            }
        } else if (GameObject.FindGameObjectsWithTag("Friend").Length == 0 && 
            GameObject.FindGameObjectsWithTag("Friend").Length == 0) {
            if (currentWaveIdx < waves.Count-1) {
                currentWaveIdx++;
                nextSpawnIdx = 0;
            } else {
                // all waves completed
                gameObject.SetActive(false);;
            }
        }
    }
}
