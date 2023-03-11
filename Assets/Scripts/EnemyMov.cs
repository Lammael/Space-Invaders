using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    public GameObject laserEnemy;

    public Transform shootLocation;
    
    public float enemySpeed;

    public float maxTimeLaser;

    public float currentTime;

    public bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMoviment();

        if (canShoot == true)
        {
            shootLaser();
        }
    }

    private void EnemyMoviment()
    {
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);
    }

    private void shootLaser()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0) 
        {
            Instantiate(laserEnemy, shootLocation.position, Quaternion.Euler(0f, 0f, 90f));
            currentTime = maxTimeLaser;
        }
    }
}
