using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//We do be balling
public class Ball : MonoBehaviour
{
    
    [SerializeField]
    float velocidad = 5, deteccionHorizontal =0.4f, fuerzaEmpuje = 2;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(3,3), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * velocidad;
        if (Mathf.Abs(rb.velocity.y) < deteccionHorizontal)
        {
            rb.AddForce(Vector2.down *fuerzaEmpuje, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            Destroy(collision.gameObject);
            Datos.puntos += 50;
        }
    }

}
