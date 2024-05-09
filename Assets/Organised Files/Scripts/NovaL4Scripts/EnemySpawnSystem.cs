using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnSystem : MonoBehaviour
{
    
    public GameObject[] randomEnemy;
    public int randomvar;
    
    

   
    // Start is called before the first frame update
    void Start()
    {

        Spawner();
       
    }

    


   

    void Spawner()
    {
        
            randomvar = Random.Range(1, 8);

            if (randomvar == 1)
            {

            }
            else if (randomvar == 2)
            {
                Instantiate(randomEnemy[0], transform.position, Quaternion.identity);
            }
            else if (randomvar == 3)
            {
                Instantiate(randomEnemy[1], transform.position, Quaternion.identity);
            }
        else if (randomvar == 4)
        {
            Instantiate(randomEnemy[2], transform.position, Quaternion.identity);
        }
        else if (randomvar == 5)
        {
            Instantiate(randomEnemy[3], transform.position, Quaternion.identity);
        }
        else if (randomvar == 6)
        {
            Instantiate(randomEnemy[4], transform.position, Quaternion.identity);
        }
        else if (randomvar == 7)
        {
            Instantiate(randomEnemy[5], transform.position, Quaternion.identity);
        }
        Debug.Log("spawned");
            
            
        
    }
}
