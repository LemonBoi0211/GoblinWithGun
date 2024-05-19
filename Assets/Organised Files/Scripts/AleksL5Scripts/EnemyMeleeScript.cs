 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeScript : MonoBehaviour
{
    public float Health = 1f;
    public float Speed = 5f;
    public Rigidbody2D rb;
    public Animator Animator;
    public MeleeAreaOfAttackScript AttackScript;
    PlayerHealthScript PlayerHealthScript;
    public GameObject[] consumables;
    public int randonConsumable;
    GameObject consumableA;
    GameObject consumableB;
    GameObject consumableC;
    GameObject consumableD;
    GameObject consumableE;
    GameObject player;
    Transform playerTransform;
    public bool CanDropRifleAmmo;
    public bool CanDropRocketAmmo;
    // LayerMask collisionLayer;
    public bool CanMove = false;
    public GameObject DeathSoundGameobject;
    public AudioSource DeathSound;
    public GameObject deathParticles;
    //   public bool RaycastSeePlayer = false;
    void Awake()
    {
        
      //  collisionLayer = LayerMask.NameToLayer("collisionLayer");
        rb = gameObject.GetComponent<Rigidbody2D>();
        Animator = gameObject.GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.GetComponent<Transform>();
        DeathSoundGameobject = GameObject.FindGameObjectWithTag("DeathSound");
        DeathSound = DeathSoundGameobject.GetComponent<AudioSource>();
        PlayerHealthScript = player.GetComponent<PlayerHealthScript>();
        consumableA = GameObject.FindGameObjectWithTag("CollectableA");
        consumableB = GameObject.FindGameObjectWithTag("CollectableB");
        consumableC = GameObject.FindGameObjectWithTag("CollectableC");
        consumableE = GameObject.FindGameObjectWithTag("CollectableE");
    }
    void Start()
    {
        



        Health = 1f;
        consumables = new GameObject[5];
        consumables[0] = consumableA;
        consumables[1] = consumableB;
        consumables[2] = consumableC;
        consumables[4] = consumableE;


        foreach (GameObject obj in consumables)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }

    }

    void FixedUpdate()
    {
      if (CanMove == true)
      { 
        if (playerTransform != null)
            {
                float distance = Vector3.Distance(transform.position, playerTransform.position);
                Vector2 direction = (playerTransform.position - transform.position).normalized;

                if (distance > 1)
                {
                    Animator.SetBool("IsAttacking", false);
                    rb.AddForce(direction * Speed, ForceMode2D.Force);
                }
                else
                {
                    Animator.SetBool("IsAttacking", true);

                    if (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
                    {

                    }
                }
        }
      }




    }
     private void OnTriggerEnter2D(Collider2D other)
     {
            if (other.CompareTag("Bullet"))
            {
               Destroy(other.gameObject);
               Health -= 0.25f;
            Speed = 100f;
            Invoke("ResetSpeed", 0.3f);

        }

        if (other.CompareTag("BulletRifle"))
        {
            Destroy(other.gameObject);
            Health -= 0.5f;
            Speed = 100f;
            Invoke("ResetSpeed", 0.3f);
        }

        if (other.CompareTag("Rocket"))
        {
            Health -= 0.4f;
            Speed = 100f;
            Invoke("ResetSpeed", 0.3f);
        }

        if (other.CompareTag("MainCamera"))
        {
            CanMove = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("MainCamera"))
        {
           // CanMove = false;
        }
    }
    private void Update()
     {
    //    Vector2 direction = player.transform.position - transform.position;
     //   RaycastHit2D hit;

     //   if (Physics2D.Raycast(transform.position, direction, 100f, collisionLayer))
      //  {

       //     hit = Physics2D.Raycast(transform.position, direction, 100f, collisionLayer);

         //   if (hit.collider.gameObject == player)
       //     {
         //       Debug.Log("It works!");
        //        RaycastSeePlayer = true;
        //    }
         //   else
          //  {
       //         Debug.Log("It doesn't work");
       //         RaycastSeePlayer = false;
       //     }

    //        Debug.DrawRay(transform.position, direction, Color.red);
   //     }


        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (playerTransform.position.x < transform.position.x)
            {
                this.transform.localScale = new Vector3(-1.8f, 1.8f, 1.8f);
            }
            if (playerTransform.position.x >= transform.position.x)
            {
                this.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
            }


        if (Health <= 0.1)
        {
            Instantiate(consumables[4], transform.position, Quaternion.identity);
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


      
     }

    void Hit()
        {
           if (AttackScript.canDoDamage == true)
           {
             Debug.Log("Hit");
             PlayerHealthScript.Health -= 0.25f;
           }
        }

    void ResetSpeed()
    {
        Speed = 420f;
    }
} 