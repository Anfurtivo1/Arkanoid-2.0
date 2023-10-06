using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    [SerializeField]
    GameObject prefabLadrillo;
    // Start is called before the first frame update
    void Start()
    {

        for (float x = -8; x <= 8; x++)
        {
            for (float y = 1; y < 4; y+= 0.33f)
            {
                GameObject clon = Instantiate(prefabLadrillo);
                clon.transform.position = new Vector3(x, y, 0);
            }

        }

        //for (float i = -8; i <= 8; i++)
        //{
        //    GameObject clon = Instantiate(prefabLadrillo);
        //    clon.transform.position = new Vector3(i, 3, 0);
        //}

        //for (float i = -8; i <= 8; i++)
        //{
        //    GameObject clon = Instantiate(prefabLadrillo);
        //    clon.transform.position = new Vector3(i, 2, 0);
        //}

        //for (float i = -8; i <= 8; i++)
        //{
        //    GameObject clon = Instantiate(prefabLadrillo);
        //    clon.transform.position = new Vector3(i, 1, 0);
        //}

        //for (float i = -8; i <= 8; i++)
        //{
        //    GameObject clon = Instantiate(prefabLadrillo);
        //    clon.transform.position = new Vector3(i, 0, 0);
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
