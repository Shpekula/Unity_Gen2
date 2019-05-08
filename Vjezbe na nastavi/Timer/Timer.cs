using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Upiši broj minuta za razinu:")]
    public float minute; //Koliko hoćemo da traje igra u minutama

    public Text time_text; //Text na kojem se prikazuje vrijeme

    void Start() // Pretavaramo minute u sekunde
    {
        minute = minute * 60;
    }

    public void Update()
    {
        minute -= Time.deltaTime; //Oduzimamo vrijeme

        if(minute >= 0) //Ako je veće od 0 sekundi
        {
            float minutes = Mathf.FloorToInt(minute / 60); //Djelimo da dobijemo cijeli broj
            float seconds = Mathf.FloorToInt(minute % 60); //Djelimo da dodbijemo ostatak
            if(minutes < 10 && seconds < 10) //Ako je manje od 10 sekundi/minuta da imamo 0 ispred radi ljepšeg zapisa
            {
                time_text.text = "0" + minutes + ":" + "0" + seconds; 
            }
            else if (minutes < 10 && seconds > 10) //Sekunde su u ovom slučaju dvoznamenkaste
            {
                time_text.text = "0" + minutes + ":" + seconds;
            }
            else //Prikazuj dvoznamenkaste minute i sekunde
            {
                time_text.text = minutes + ":" + seconds;
            }
        }
    }
}
