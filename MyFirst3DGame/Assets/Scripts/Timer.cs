using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float MaxTime = 60f;
    private float CountDown = 0f;
    // Start is called before the first frame update
    void Start()
    {
        CountDown = MaxTime;
    }

    // Update is called once per frame
    void Update()
    {
        //restando tiempo
        CountDown -= Time.deltaTime;
        Debug.Log(CountDown);
        if(CountDown<=0)
        {
            Debug.Log("Perdiste , Sos de Manera Perdiste");
            Coin.CoinsCount = 0;
            SceneManager.LoadScene("MainScene");
        }
    }
}
