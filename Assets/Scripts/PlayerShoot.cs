using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{ 
    public PlayerLaser laser;

    private bool laserActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            ShootLaser();
        }
    }

    private void ShootLaser()
    {
        if (!laserActive)
        { 
            PlayerLaser projectile = Instantiate(laser, transform.position, Quaternion.identity);
            projectile.destroyed += LaserDestroyed;
            laserActive = true;
        }
    }
    private void LaserDestroyed()
    {
        laserActive = false;
    }
}
