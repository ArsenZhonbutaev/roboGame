using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject[] tiles;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(tiles[0], transform.position, Quaternion.identity);
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(tiles[1], transform.position, Quaternion.identity);
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(tiles[2], transform.position, Quaternion.identity);
        }

    }

}
