using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerShakeScript : MonoBehaviour
{

    public Transform cameraTransform;
    public float shakeDuration = 0f;
    public float rotationIntensity = 0.5f;
    private Quaternion originalRot = Quaternion.identity;
    public GlitchedGunScript PistolScript;
    public RifleGunScript RifleScript;
    public RPGScript RPGScript;

    
    private void Start()
    {
        shakeDuration = 0;
    }
    void Update()
    {
        if (shakeDuration > 0)
        {
          
            Vector3 randomRotation = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f) * rotationIntensity;
            cameraTransform.localRotation = originalRot * Quaternion.Euler(randomRotation);

            shakeDuration -= Time.deltaTime;
        }
        else
        {
            shakeDuration = 0f;
            cameraTransform.localRotation = originalRot; 
        }


        if (PistolScript.IsFiring == true)
        {
            rotationIntensity = 0.5f;
            shakeDuration = 0.1f;
            PistolScript.IsFiring = false;
        }

        if (RifleScript.IsFiring == true)
        {
            rotationIntensity = 1f;
            shakeDuration = 0.1f;
            RifleScript.IsFiring = false;
        }

        if (RPGScript.IsFiring == true)
        {
            rotationIntensity = 3f;
            shakeDuration = 0.1f;
            RPGScript.IsFiring = false;
        }
    }

    
}
