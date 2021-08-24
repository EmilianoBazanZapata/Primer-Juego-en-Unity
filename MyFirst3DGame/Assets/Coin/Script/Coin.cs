//usings necesarios para que todo funcione 
//de forma normal
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
  declaracion de la clase
*/
public class Coin : MonoBehaviour
{
  public static int CoinsCount = 0;




    // Start is called before the first frame update
    private void Start()
    {
        //Debug.Log("El Juego Comenzo");
        //aumento el contador de monedas
        Coin.CoinsCount ++;
        Debug.Log("ahora hay :" + Coin.CoinsCount + " Monedas");
    }
  
    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("El Juego Esta Funcionando");
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Player"))
      {
        //Debug.Log("se provoco una colision");
        //primero debo restar y luego destruir el objeto asi el contador cambia de valor 
        Coin.CoinsCount--;
        if(Coin.CoinsCount == 0)
        {
          Debug.Log("El Juego Termino");

          GameObject GameManager = GameObject.Find("GameManager");
          //cuando Obtengo todas las monedas destruyo el GameManager para parar el tiempo
          Destroy(GameManager);
        }
        Destroy(gameObject);
      }
    }
}