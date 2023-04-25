using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] duck;
    [SerializeField] private Transform[] spawPoint;

    [SerializeField] private float timeSpawn;
   // [SerializeField] private float timeDespawn;

    private void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    private void SpawnCars()
    {
        int randDuckIndex = Random.Range(0, duck.Length);
        int randSpawnIndex = Random.Range(0, spawPoint.Length);


        GameObject newDuck = Instantiate(duck[randDuckIndex], spawPoint[randSpawnIndex].position, spawPoint[randSpawnIndex].rotation);
       // Destroy(newDuck, timeDespawn);
    }

    private IEnumerator SpawnTimer()
    {
        while (true)
        {

            SpawnCars();
            yield return new WaitForSeconds(timeSpawn);

        }

       
    }
}
