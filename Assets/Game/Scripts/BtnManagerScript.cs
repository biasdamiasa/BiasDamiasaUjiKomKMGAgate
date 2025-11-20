using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManagerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGamePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void LoadCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
