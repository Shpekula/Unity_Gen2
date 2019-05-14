using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak6 : MonoBehaviour
{
    //Napisati skritpu koja će učitati Rigidbody komponentu u Startu

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
}
