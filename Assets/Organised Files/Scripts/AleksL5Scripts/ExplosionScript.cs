using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    public CamerShakeScript CameraShakeScript;
    public GameObject Camera;
    public AudioSource explosion;
    public GameObject explosionGameObject;
    public GameObject Light;
    private void Awake()
    {
        Camera = GameObject.FindWithTag("MainCamera");
        explosionGameObject = GameObject.FindWithTag("ExplosionSound");
        explosion = explosionGameObject.GetComponent<AudioSource>();
       CameraShakeScript = Camera.GetComponent<CamerShakeScript>();
    }
    void Start()
    {
        explosion.Play();
        CameraShakeScript.shakeDuration = 0.1f;
        CameraShakeScript.rotationIntensity = 3f;
        Destroy(gameObject, 0.15f);
        Instantiate(Light, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
