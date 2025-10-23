using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 20.0f;
    public GameObject projectilePrefab;

                       
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
                {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);   
        }
        else if (Input.GetKey(KeyCode.LeftShift)){
            transform.Translate(horizontalInput * speed*3 * Time.deltaTime * Vector3.right);
        }

        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //lunch projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        } 
        
    }
}
