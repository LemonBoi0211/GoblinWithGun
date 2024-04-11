using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour
{
    //Currently a fixed number, will have to be modular later on to adjust for level of enemies
    public float Health = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        {
            if (other.CompareTag("Bullet"))
            {
                Health -= 0.2f;
            }
        }
    }
}
