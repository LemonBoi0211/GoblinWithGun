using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnSystem : MonoBehaviour
{
    
    public GameObject[] randomEnemy;
    public int randomvar;
    
    public int canSpawnCounter = 0;

   
    // Start is called before the first frame update
    void Start()
    {

        Spawner();
        StartCoroutine(Spawntimer());
    }

    private void Update()
    {
        Spawner();
        Spawntimer();
    }


    IEnumerator Spawntimer()
    {
        yield return new WaitForSecondsRealtime(5);
    }

    void Spawner()
    {
        if (canSpawnCounter <= 5)
        {
            randomvar = Random.Range(1, 3);

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
            Debug.Log("wavespawned");
            canSpawnCounter++;
            Spawntimer();
        }
    }
}
