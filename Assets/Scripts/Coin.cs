using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Variables
    public static int countCoins = 0;

    // Start is called before the first frame update
    void Start()
    {
        Coin.countCoins++;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider Collider)
    {
        Debug.Log("Se ha recolectado la moneda #" + Coin.countCoins);
        if (Collider.CompareTag("Player"))
        {
            Destroy(gameObject); 
        }
    }
    void OnDestroy()
    {
        Coin.countCoins--;
        if (Coin.countCoins <= 0)
        {
            GameObject timer = GameObject.Find("GameTimer");
            Destroy(timer);
            Debug.Log("El juego ha terminado, has ganado!!!");
        }
    }
}
