using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    public CamerShakeScript CameraShakeScript;
    public GameObject Camera;
    private void Awake()
    {
        Camera = GameObject.FindWithTag("MainCamera");
        CameraShakeScript = Camera.GetComponent<CamerShakeScript>();
    }
    void Start()
    {
        CameraShakeScript.shakeDuration = 0.1f;
        CameraShakeScript.rotationIntensity = 3f;
        Destroy(gameObject, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
