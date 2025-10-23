using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float topBound = 30f;
    private float lowerBound = -10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Debug.Log("GAME OVER,U are pussy for losing");
            Destroy(gameObject);
            Debug.Log("GAME OVER");
        }
    }
}
