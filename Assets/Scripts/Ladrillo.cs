using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladrillo : MonoBehaviour
{
    [SerializeField]
    float probPowerUp;
    [SerializeField]
    GameObject[] prefabPowerUps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pelota")
        {
            if (Random.Range(0f,100f) < probPowerUp)
            {
                int aleatorio = Random.Range(0,prefabPowerUps.Length);
                GameObject clon = Instantiate(prefabPowerUps[aleatorio]);
                clon.transform.position = transform.position;
            }
        }
    }

}
