using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManagerScript : MonoBehaviour
{
    public int WeaponSelected = 1;
    public int LevelUnlocked = 1;

    //1 = Glitched gun    2= Rifle     3= RPG
    void Start()
    {
        WeaponSelected = 0;
        LevelUnlocked = 0;
    }

    // Update is called once per frame
    void Update()
    {
       if (LevelUnlocked >= 1)
       { 
         if (Input.GetKey(KeyCode.Alpha1))
         {
            WeaponSelected = 1;

         }
       }
        if (LevelUnlocked >= 2)
        {
            if (Input.GetKey(KeyCode.Alpha2))
            {
                WeaponSelected = 2;
            }
        }

        if (LevelUnlocked >= 3)
        {
            if (Input.GetKey(KeyCode.Alpha3))
            {
                WeaponSelected = 3;
            }
        }
    }
}
