using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawner : MonoBehaviour
{
    public GameObject enemyMissile;
    public float spawnerTimer;
    public float spawnMax = 10;
    public float spawnMin = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnerTimer = Random.Range(spawnMin, spawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        Missile(); 
    }

    private void Missile()
    {
        spawnerTimer -= Time.deltaTime;
        if(spawnerTimer <= 0)
        {
            Instantiate(enemyMissile, transform.position, Quaternion.identity);
            spawnerTimer = Random.Range(spawnMin, spawnMax);
        }
        
    }
}
