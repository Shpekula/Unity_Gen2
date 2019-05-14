using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak4 : MonoBehaviour
{
    //Napisati skriptu koja će u startu definirati scale od x i z osi i u startu ih povećati za 5

    float xScale;
    float zScale;

    private void Start()
    {
        xScale = gameObject.transform.localScale.x;
        zScale = gameObject.transform.localScale.z;
    }

    private void Update()
    {
        gameObject.transform.localScale += new Vector3(5, 0, 5);
    }
}