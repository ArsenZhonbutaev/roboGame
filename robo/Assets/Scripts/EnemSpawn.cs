using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemSpawn : MonoBehaviour
{
    public float startTimeBtwSpawn;
    private float timeBtwSpawn;
    public GameObject[] enems;

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, enems.Length);
            Instantiate(enems[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
