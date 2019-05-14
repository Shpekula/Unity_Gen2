using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak8 : MonoBehaviour
{
    //Napisati skriptu koja će naš gameobject povećeati za vrijednost x po y osi kad god igrač stisne space

    public float xScale;

    private void Start()
    {
        xScale = transform.localScale.x;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += new Vector3(0, xScale, 0);
        }
    }
}