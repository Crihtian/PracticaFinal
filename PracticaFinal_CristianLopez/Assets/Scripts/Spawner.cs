using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] duck;
    [SerializeField] private Transform[] spawPoint;

    [SerializeField] private float timeSpawn;
   

    private void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    private void SpawnDucks()
    {
        int randDuckIndex = Random.Range(0, duck.Length);
        int randSpawnIndex = Random.Range(0, spawPoint.Length);


        GameObject newDuck = Instantiate(duck[randDuckIndex], spawPoint[randSpawnIndex].position, spawPoint[randSpawnIndex].rotation);
       
    }

    private IEnumerator SpawnTimer()
    {
        while (true)
        {

            SpawnDucks();
            yield return new WaitForSeconds(timeSpawn);

        }

       
    }
}
