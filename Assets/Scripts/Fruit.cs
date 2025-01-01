using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            Debug.Log("fruit picked up");
            FindObjectOfType<SpawnFruits>().OnFruitPickedUp();
            FindObjectOfType<GameManager>().AddScore(10);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Finish")) {
            Debug.Log("fruit missed");
            FindObjectOfType<SpawnFruits>().OnFruitMissed();
            FindObjectOfType<GameManager>().FruitMissed();
            Destroy(gameObject);
        }
    }
}
