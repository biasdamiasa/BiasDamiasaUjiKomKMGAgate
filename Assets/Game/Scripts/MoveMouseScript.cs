using UnityEngine;

public class MoveMouseScript : MonoBehaviour
{
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

        // Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Vector2 playerPosition = new Vector2(worldMousePosition.x, worldMousePosition.y);

        // Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0,0,0));
        // Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));

        // playerPosition.x = Mathf.Clamp(playerPosition.x, minimum.x, maximum.x);

        // transform.position = Vector2.MoveTowards(transform.position, worldMousePosition, 1f);
    }
}
