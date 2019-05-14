using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak2 : MonoBehaviour
{
    //Množenje 2 javna broja. Oba trebaju biti vidljiva u inspectoru, 
    //a rezultat treba pisati u Consoli preko Debug-a.Dva broja se množe u Update-u.

    public float broj1 = 12.3f;
    public float broj2 = 5;

    private void Update()
    {
        float mnozenje = broj1 * broj2;
        Debug.Log("Umnožak je: " + mnozenje);
    }
}
