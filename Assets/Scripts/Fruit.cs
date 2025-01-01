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
            FindObjectOfType<SpawnFruits>().OnFruitPickedUp();
            FindObjectOfType<GameManager>().AddScore(10);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Finish"))
        {
            FindObjectOfType<SpawnFruits>().OnFruitMissed();
            FindObjectOfType<GameManager>().FruitMissed();
            Destroy(gameObject);
        }
    }
}
