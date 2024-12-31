using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7.5f;
    public float boundaryLeft = -10.67f;
    public float boundaryRight = 10.67f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        // calculate movement
        float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        
        // set boundaries
        float newX = Mathf.Clamp(transform.position.x + translation, boundaryLeft, boundaryRight);

        // move the player
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
