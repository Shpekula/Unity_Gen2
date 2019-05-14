using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak10 : MonoBehaviour
{
    //Jedan gameobject se kreće po z osi, ali kad dode u collider sa drugim, vraća se u nazad

    public float brzina = 1;

    private void Update()
    {
        transform.position += new Vector3(0, 0, brzina);
    }

    public void OnTriggerEnter(Collider other)
    {
        brzina = -brzina;
    }
}