using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoTextScript : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public CollectableSystem PlayerAmmoScript;
    public WeaponManagerScript weaponManagerScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (weaponManagerScript.WeaponSelected == 1)
        {
            Text.text = ("Ammo left: \u221E");
        }

        if (weaponManagerScript.WeaponSelected == 2)
        {
            Text.text = ("Ammo left: "+ PlayerAmmoScript.RifleAmmo);
        }

        if (weaponManagerScript.WeaponSelected == 3)
        {
            Text.text = ("Ammo left: " + PlayerAmmoScript.RocketAmmo);
        }
    }
}
