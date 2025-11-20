using Unity.Mathematics;
using UnityEngine;

public class MoveMouseScript : MonoBehaviour
{
    public GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 squarePosition = new Vector2(worldMousePosition.x, transform.position.y);

        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0,0,0));
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));

        squarePosition.x = Mathf.Clamp(squarePosition.x, minimum.x, maximum.x);
        
        transform.position = squarePosition;

        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        // Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Vector2 playerPosition = new Vector2(worldMousePosition.x, worldMousePosition.y);

        // Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0,0,0));
        // Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));

        // playerPosition.x = Mathf.Clamp(playerPosition.x, minimum.x, maximum.x);

        // transform.position = Vector2.MoveTowards(transform.position, worldMousePosition, 1f);
    }

    public void Shoot()
    {
        Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 squarePosition = new Vector2(clickPosition.x, transform.position.y);

        Vector2 shootPosition = new Vector3 (squarePosition.x, transform.position.y, 0);

        Instantiate(bullet, shootPosition, Quaternion.identity);
    }
}
