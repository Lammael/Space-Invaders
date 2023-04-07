using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{
    public float laserSpeed;


    public System.Action destroyed;
    void Update()
    {
        transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Enemy1"
            || collision.gameObject.tag == "Enemy2" || collision.gameObject.tag == "Wall")
        {
            destroyed.Invoke();
            Destroy(gameObject);
        }
    }
}
