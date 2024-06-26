using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleGunScript : MonoBehaviour
{

    public Transform Player;
    public GameObject Bullet;
    public Transform FirePoint;
    public WeaponManagerScript WeaponManagerScript;
    public SpriteRenderer Sprite;
    public bool CanFire = true;
    public float Timer; 
    public CollectableSystem AmmoScript;
    public bool IsFiring;
    public AudioSource rifleSound;
    public AudioSource riflePing;
    public bool needMOBullets = false;

    // Use this for initialization
    void Start()
    {
        Timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
     
        if (WeaponManagerScript.WeaponSelected == 2)
        {
            if (CanFire == true && !needMOBullets)
            {
                if  (AmmoScript.RifleAmmo > 0)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
                        Timer = 0.5f;
                        AmmoScript.RifleAmmo--;
                        IsFiring = true;
                        rifleSound.Play();
                    }
                }
                else
                {
                    Timer = 0.5f;
                    riflePing.Play();
                    needMOBullets = true;
                }
            }
            


                //Look a mouse
                Vector3 mousePos = Input.mousePosition;
            Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
            mousePos.x = mousePos.x - objectPos.x;
            mousePos.y = mousePos.y - objectPos.y;
            float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            Sprite.enabled = true;

            this.transform.position = Player.position;
        }
        else
        {
            Sprite.enabled = false;
        }

        if (Timer > 0) 
        {
            CanFire = false;
        }
        else
        {
            CanFire = true;
        }
    }
}