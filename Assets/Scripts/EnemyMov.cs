using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    public float movSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovEnemy();
    }
    
    private void MovEnemy()
    {
        transform.Translate(Vector2.right * movSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
           transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
           movSpeed *= -1;
            
        }
    }
}
