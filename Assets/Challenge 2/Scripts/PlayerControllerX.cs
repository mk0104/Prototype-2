using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float startDelay = 0.3f;
    private float spawnInterval = 0.5f;

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("DogAction", startDelay, spawnInterval);
        // On spacebar press, send dog
      
    }
    void DogAction()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
