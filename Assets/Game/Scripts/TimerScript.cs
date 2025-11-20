using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float waktu;
    public float maxWaktu = 10;
    public bool waktuBerjalan = true;
    public Image progressFill;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DisplayTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (waktu == maxWaktu)
        {
            SceneManager.LoadScene("Result");
        }
    }

    IEnumerator DisplayTimer()
    {
        while (waktuBerjalan && waktu < maxWaktu)
        {
            waktu++;
            progressFill.fillAmount = waktu / maxWaktu;

            yield return new WaitForSeconds(1);                    
        }

    }
}
