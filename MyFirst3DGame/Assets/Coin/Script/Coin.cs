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
    // Start is called before the first frame update
    private void Start()
    {
        //Debug.Log("El Juego Comenzo");
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
        Destroy(gameObject);
      }
    }
}