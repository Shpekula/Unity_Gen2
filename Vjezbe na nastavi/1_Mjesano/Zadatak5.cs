using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak5 : MonoBehaviour
{
    //Napišite skritpu koja će objekt rotirati po y osi za neku javnu vrijednost svaki frame.

    public float broj;

    private void Update()
    {
        transform.Rotate(new Vector3(0, broj, 0));
    }
}
