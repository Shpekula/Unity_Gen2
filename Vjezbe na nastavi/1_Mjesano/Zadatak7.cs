using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak7 : MonoBehaviour
{
    //Napisati skriptu koja će služiti kao Timer. 
    //Početna vrijednost će biti javna, ali za test će biti minuta i pol i odbrojavat će se do nula,
    //kada dođe do nula izaći će se iz video igre.

    public float vrijeme = 90.0f;

    private void Update()
    {
        vrijeme -= Time.deltaTime;
        if (vrijeme <= 0)
        {
            Application.Quit();
        }
    }
}
