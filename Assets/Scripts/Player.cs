
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float velocity = 5.5f;
    private int vidas = 3;
    protected string nombre = "Yo mismo";
    bool disparo = false;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(velocity, 0);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-velocity, 0);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

    }
}
