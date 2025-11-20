using Unity.Mathematics;
using UnityEngine;

public class MoveMouseScript : MonoBehaviour
{
    public GameObject bullet;

    // public float speed = 5.0f;
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
    }

    public void Shoot()
    {
        Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 squarePosition = new Vector2(clickPosition.x, transform.position.y);

        Vector2 shootPosition = new Vector3 (squarePosition.x, transform.position.y, 0);

        Instantiate(bullet, shootPosition, Quaternion.identity);

        // bulletShoot.transform.Translate(0, Time.deltaTime * speed, 0 );
    }
}
