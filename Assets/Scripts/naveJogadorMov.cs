using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naveJogadorMov : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;

    public GameObject playerLaser;

    public Transform shootLocation;

    public float speed;

    public bool isDoubleLaser;

    private Vector2 keyboardPressed;

    // Start is called before the first frame update
    void Start()
    {
        isDoubleLaser = false;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMov();
        ShootLaser();
    }

    private void PlayerMov()
    {
        keyboardPressed = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rigidBody2D.velocity = speed * keyboardPressed.normalized;
    }

    private void ShootLaser()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(isDoubleLaser == false)
            {
                Instantiate(playerLaser, shootLocation.position, shootLocation.rotation);
            }
        }
    }
}
