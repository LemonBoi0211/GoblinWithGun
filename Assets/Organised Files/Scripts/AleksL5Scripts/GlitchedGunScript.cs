using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchedGunScript : MonoBehaviour
{

    public Transform Player;
    public GameObject Bullet;
    public Transform FirePoint;
    public WeaponManagerScript WeaponManagerScript;
    public SpriteRenderer Sprite;
    public bool IsFiring;
    public AudioSource pistolSound;

    // Use this for initialization
    void Start()
    {
        Sprite.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (WeaponManagerScript.WeaponSelected== 1)
        {
         //Look a mouse
         Vector3 mousePos = Input.mousePosition;
         Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
         mousePos.x = mousePos.x - objectPos.x;
         mousePos.y = mousePos.y - objectPos.y;
         float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
         transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
         Sprite.enabled = true;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
                IsFiring = true;
                pistolSound.Play();
            }
        }
        else
        {
            Sprite.enabled = false;
        }


      
      

        this.transform.position = Player.position;
    }

}
