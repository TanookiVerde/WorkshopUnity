using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnableObject;
    [SerializeField]
    private float minTimeBetweenSpawns;
    [SerializeField]
    private float maxTimeBetweenSpawns;

    private void Start()
    {
        StartCoroutine(SpawnLoop());
    }
    private IEnumerator SpawnLoop()
    {
        while(true)
        {
            float wait = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(wait);
            Spawn();
        }
    }
    public void Spawn()
    {
        GameObject newObject = Instantiate(spawnableObject);
        newObject.transform.position = transform.position;
    }
}
