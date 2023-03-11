using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserMov : MonoBehaviour
{
    public float laserSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyLaser();
    }

    private void EnemyLaser()
    {
        transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);
    }
}
