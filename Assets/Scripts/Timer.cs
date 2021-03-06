using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float maxTime = 60.0f;
    private float countDown = 0.0f;
    public Text TimerText;
    private float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        countDown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        Debug.Log("Restan: " + countDown);
        if (countDown <= 0)
        {
            //Coin.countCoins = 0;
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
        writeTimer(tiempo);
    }

    private void writeTimer(float tiempo)
    {
        tiempo = countDown;
        TimerText.text = "Tiempo restante: " + tiempo.ToString() + " Seg.";
    }
}
