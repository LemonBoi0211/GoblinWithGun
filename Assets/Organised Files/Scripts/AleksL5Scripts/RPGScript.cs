using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGScript : MonoBehaviour
{
    public Transform Player;
    public GameObject Bullet;
    public Transform FirePoint;
    public WeaponManagerScript WeaponManagerScript;
    public SpriteRenderer Sprite;
    public bool CanFire = true;
    public float Timer;
    public CollectableSystem AmmoScript;
    // Use this for initialization
    void Start()
    {
        Timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;

        if (WeaponManagerScript.WeaponSelected == 3)
        {
            if (AmmoScript.RocketAmmo > 0)
            {
                if (CanFire == true)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
                        Timer = 0.5f;
                        AmmoScript.RocketAmmo--;
                    }
                }
            }
            else
            {
                Timer = 0.5f;
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

