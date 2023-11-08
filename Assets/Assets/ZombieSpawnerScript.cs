using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    public GameObject Enemy;
    private float delay;
    public Transform Spawn;

    public List<GameObject> Enemies;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        delay -= Time.deltaTime;
        if (delay <= 0)
        {
            Instantiate(Enemy, Spawn.position, Quaternion.identity);
            delay = 15;

            //ZombieMovement.Speed = 2;
        }
    }
}

