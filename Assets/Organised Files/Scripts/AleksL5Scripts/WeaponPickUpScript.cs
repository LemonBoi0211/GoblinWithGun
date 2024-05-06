using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUpScript : MonoBehaviour
{
    public WeaponManagerScript weaponManagerScript;
    public int WeaponNumber;

    //1 = Pistol 
    //2 = Rifle
    //3 = Rocket

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if (WeaponNumber == 1)
      { 
        if (other.gameObject.tag == "Player")
        {
            weaponManagerScript.LevelUnlocked = 1;
            weaponManagerScript.WeaponSelected = 1;
            Destroy(gameObject);
        }
      }

        if (WeaponNumber == 2)
        {
            if (other.gameObject.tag == "Player")
            {
                weaponManagerScript.LevelUnlocked = 2;
                weaponManagerScript.WeaponSelected = 2;
                Destroy(gameObject);
            }
        }

        if (WeaponNumber == 3)
        {
            if (other.gameObject.tag == "Player")
            {
                weaponManagerScript.LevelUnlocked = 3;
                weaponManagerScript.WeaponSelected = 3;
                Destroy(gameObject);
            }
        }
    }
}
