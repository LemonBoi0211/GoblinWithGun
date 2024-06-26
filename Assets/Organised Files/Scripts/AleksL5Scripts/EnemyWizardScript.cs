using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyWizardScript : MonoBehaviour
{
    //Remove Health if it ever cause problems with the other health script.
    public float Health = 1f;
    public float direction;
    public float Speed = 5f;
    public float detectionRange = 5f;
    public float knockbackForce = 10f;
    public Rigidbody2D rb;
    public GameObject[] consumables;
    public int randonConsumable;
    public float knockbackForceRifle = 10f;
    public GameObject consumableA;
    public GameObject consumableB;
    public GameObject consumableC;
    public GameObject consumableD;
    public GameObject consumableE;
    GameObject player;
    Transform playerTransform;
    public bool CanMove = false;
    public GameObject DeathSoundGameobject;
    public AudioSource DeathSound;
    public GameObject deathParticles;
    public bool CanDropRifleAmmo;
    public bool CanDropRocketAmmo;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.GetComponent<Transform>();
        DeathSoundGameobject = GameObject.FindGameObjectWithTag("DeathSound");
        DeathSound = DeathSoundGameobject.GetComponent<AudioSource>();
        consumableA = GameObject.FindGameObjectWithTag("CollectableA");
        consumableB = GameObject.FindGameObjectWithTag("CollectableB");
        consumableC = GameObject.FindGameObjectWithTag("CollectableC");
        consumableE = GameObject.FindGameObjectWithTag("CollectableE");
    }


    void Start()
    {
        Health = 1f;   
        knockbackForce = knockbackForce * 2;
        consumables = new GameObject[5];
        consumables[0] = consumableA;
        consumables[1] = consumableB;
        consumables[2] = consumableC;
       // consumables[4] = consumableE;


        foreach (GameObject obj in consumables)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }

    }


    void Update()
    {

      if (CanMove == true)
      {
            if (Health <= 0.1)
            {
               // Instantiate(consumables[4], transform.position, Quaternion.identity);
                randonConsumable = Random.Range(6, 9);

                if (randonConsumable <= 5)
                {

                }
                else if (randonConsumable == 6)
                {
                    Instantiate(consumables[0], transform.position, Quaternion.identity);
                }
                else if (randonConsumable == 7)
                {
                    if (CanDropRifleAmmo == true)
                    {
                        Instantiate(consumables[1], transform.position, Quaternion.identity);
                    }
                }
                else if (randonConsumable == 8)
                {
                    if (CanDropRocketAmmo == true)
                    {
                        Instantiate(consumables[2], transform.position, Quaternion.identity);
                    }
                }
                DeathSound.Play();
                Instantiate(deathParticles, transform.position, Quaternion.identity);
                Destroy(gameObject);

            }

            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (playerTransform.position.x < transform.position.x)
        {
            this.transform.localScale = new Vector3(-1.8f, 1.8f, 1.8f);
        }
        if (playerTransform.position.x >= transform.position.x)
        {
            this.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
        }
      }

    }
    


  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Health -= 0.25f;
            Vector2 knockbackDirection = (transform.position - other.transform.position).normalized;
            rb.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);
        }

        if (other.CompareTag("BulletRifle"))
        {
            Destroy(other.gameObject);
            Health -= 0.5f;
            Destroy(other.gameObject);
            Vector2 knockbackDirection = (transform.position - other.transform.position).normalized;
            rb.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);

        }

        if (other.CompareTag("Rocket"))
        {
            Health -= 0.4f;
            Vector2 knockbackDirection = (transform.position - other.transform.position).normalized;
            rb.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);

        }

        if (other.CompareTag("MainCamera"))
        {
            CanMove = true;
        }
    }

}



