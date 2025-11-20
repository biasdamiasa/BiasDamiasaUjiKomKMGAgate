using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject bulletObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnBullet()
    {
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        
        // Instantiate(bulletObject, new Vector3)
    }
}
