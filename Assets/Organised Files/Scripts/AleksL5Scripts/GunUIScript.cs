using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GunUIScript : MonoBehaviour
{
    public int WeaponNumber;
    public WeaponManagerScript weaponManagerScript;
    public Image image;
    public bool IsGunImage = false;
    public bool IsText = false;
    public bool IsAmmoText = false;
    public TextMeshProUGUI Text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (IsText == false && IsGunImage == false && IsAmmoText == false)
      { 
        if (WeaponNumber <= weaponManagerScript.LevelUnlocked)
        {
            image.color = new Color32(255, 255, 255, 116); 
        }
        else
        {
            image.color = new Color32(255, 255, 255, 0);
        }
      }

      if (IsText == true)
      {
            if (WeaponNumber <= weaponManagerScript.LevelUnlocked)
            {
                Text.color = new Color32(255, 255, 255, 255);
            }
            else
            {
                Text.color = new Color32(255, 255, 255, 0);
            }
        }


        if (IsGunImage == true)
        {
            if (WeaponNumber <= weaponManagerScript.LevelUnlocked)
            {
                image.color = new Color32(0, 0, 0, 255);
            }
            else
            {
                image.color = new Color32(0, 0, 0, 0);
            }
        }

        if (IsAmmoText == true)
        {
            if (weaponManagerScript.LevelUnlocked > 0)
            {
                Text.color = new Color32(255, 255, 255, 255);
            }
            else
            {
                Text.color = new Color32(0, 0, 0, 0);
            }
        }
    }
}
