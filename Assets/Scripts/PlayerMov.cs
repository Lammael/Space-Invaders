using UnityEngine;

public class PlayerMov : MonoBehaviour
{ 

    public float speed;

    private Vector2 teclado;

    void Start()
    {
        
    }

    void Update()
    {
        Movimento();
    }

    private void Movimento()
    {
        teclado = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        transform.Translate(Vector2.right * teclado *speed * Time.deltaTime);
    }
}
