using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] arrayEnemy; 
    public bool masihSpawn = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnEnemy()
    {
        while (masihSpawn)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-8,8), Screen.height, 0);

            int index = Random.Range(0, arrayEnemy.Length);

            GameObject enemyToSpawn = arrayEnemy[index];

            Instantiate(enemyToSpawn, spawnPosition, Quaternion.identity);
        }
        
        yield return new WaitForSeconds(2);          
    }    
}
