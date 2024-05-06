using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAreaOfAttackScript : MonoBehaviour
{
    public bool canDoDamage = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canDoDamage = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canDoDamage = false;
        }
    }
}
