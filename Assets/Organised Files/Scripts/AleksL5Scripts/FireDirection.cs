using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDirection : MonoBehaviour
{
    public Transform player;
    public float countdownTime = 10f;
    public float currentCountdown;
    GameObject Projectile;
    public Animator WizardAnimator;
    public float FireTime;
    public EnemyWizardScript enemyWizardScript;
    void Awake()
    {
        Projectile = GameObject.FindGameObjectWithTag("WizardProjectile");
    }

    private void Start()
    {
        WizardAnimator.SetBool("IsFiring", false);
        currentCountdown = countdownTime;
    }
    void Update()
    {
      if (enemyWizardScript.CanMove == true)
      { 

        if (currentCountdown > 0f)
        {
            currentCountdown -= Time.deltaTime;
            WizardAnimator.SetBool("IsFiring", false);
        }
        else
        {
            currentCountdown = countdownTime;
            WizardAnimator.SetBool("IsFiring", true);
            Invoke("Fire", FireTime);
        }


        transform.right = player.position - transform.position;
      }
    }


    void Fire ()
    {
        Instantiate(Projectile, transform.position, transform.rotation);
    }
}
