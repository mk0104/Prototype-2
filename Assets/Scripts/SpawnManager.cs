using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    
    void SpawnRandomAnimal()
    {
        // random spawn location for animals
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        // spawn random animal from arrays
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // spawning method for spawning random animal and their location 
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
