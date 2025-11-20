using TMPro;
using UnityEngine;

public class ScoreManagerScript : MonoBehaviour
{
    public int score;
    public int nyawa;

    public TMP_Text scoretext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TambahScore()
    {
        score++;
        scoretext.text = "Skor: " + score;
    }

    public void KurangNyawa()
    {
        
    }

    
}
