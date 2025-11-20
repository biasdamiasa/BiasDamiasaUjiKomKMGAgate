using System.Collections;
using UnityEngine;

public class SpawnEnemyScript : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public bool masihSpawn = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnEnemy1());
        StartCoroutine(spawnEnemy2());
        StartCoroutine(spawnEnemy3());
        
    }

    IEnumerator spawnEnemy1()
    {
        while (masihSpawn)
        {
            //ambil posisi untuk spawn dengan posisi x antara -8 s.d. 8 dan posisi y tetap di 5
            Vector3 spawnPosition = new Vector3(Random.Range(-8,8), 5, 0);

            //Instantiate 1 daurUlangObject di spawnPosition kemudian simpan di objectBaru
            Instantiate(enemy1, spawnPosition, Quaternion.identity);

            //menentukan delay s.d. pemanggilan berikutnya di 2 detik
            yield return new WaitForSeconds(2);            
        }
    }

    IEnumerator spawnEnemy2()
    {
        while (masihSpawn)
        {
            yield return new WaitForSeconds(5);            
            //ambil posisi untuk spawn dengan posisi x antara -8 s.d. 8 dan posisi y tetap di 5
            Vector3 spawnPosition = new Vector3(Random.Range(-8,8), 5, 0);

            // //Instantiate 1 tdkDaurUlangObject di spawnPosition kemudian simpan di objectBaru
            Instantiate(enemy2, spawnPosition, Quaternion.identity);
        }
    }

    IEnumerator spawnEnemy3()
    {
        while (masihSpawn)
        {
            yield return new WaitForSeconds(7);            
            //ambil posisi untuk spawn dengan posisi x antara -8 s.d. 8 dan posisi y tetap di 5
            Vector3 spawnPosition = new Vector3(Random.Range(-8,8), 5, 0);

            //Instantiate 1 tdkDaurUlangObject di spawnPosition kemudian simpan di objectBaru
            Instantiate(enemy3, spawnPosition, Quaternion.identity);
        }
    }
}