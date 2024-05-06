using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWizardScript : MonoBehaviour
{
    //Remove Health if it ever cause problems with the other health script.

    public Transform Player;
    public float direction;
    public float Speed = 5f;
    public int Health = 100;
    public float detectionRange = 5f;
    public float knockbackForce = 10f;
    public Rigidbody2D rb;
    public GameObject[] consumables;
    public int randonConsumable;

    public GameObject consumableA;
    public GameObject consumableB;
    public GameObject consumableC;
    public GameObject consumableD;
    public GameObject consumableE;

    void Start()
    {
        consumables = new GameObject[5];
        consumables[0] = consumableA;
        consumables[1] = consumableB;
        consumables[2] = consumableC;
        consumables[3] = consumableD;
        consumables[4] = consumableE;


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
        if (Health <= 0)
        {
            Destroy(gameObject);
            Instantiate(consumables[4], transform.position, Quaternion.identity);

            randonConsumable = Random.Range(6, 10);

            if (randonConsumable <= 5)
            {

            }
            else if (randonConsumable == 6)
            {
                Instantiate(consumables[0], transform.position, Quaternion.identity);
            }
            else if (randonConsumable == 7)
            {
                Instantiate(consumables[1], transform.position, Quaternion.identity);
            }
            else if (randonConsumable == 8)
            {
                Instantiate(consumables[2], transform.position, Quaternion.identity);
            }
            else if (randonConsumable == 9)
            {
                Instantiate(consumables[3], transform.position, Quaternion.identity);
            }
            
        }

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Player.position.x < transform.position.x)
        {
            this.transform.localScale = new Vector3(-1.2f, 1.2f, 1.2f);
        }
        if (Player.position.x >= transform.position.x)
        {
            this.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }


    }
    


  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Health -= 20;
            Destroy(other.gameObject);
            Vector2 knockbackDirection = (transform.position - other.transform.position).normalized;
            rb.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);
        }
    }



}
