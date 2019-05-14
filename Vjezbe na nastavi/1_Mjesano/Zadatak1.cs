using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak1 : MonoBehaviour
{
    //Skripta u kojoj se zbrajaju 2 cijela broja. Oba broja trebaju se vidjeti u Inspectoru, 
    //te rezultat treba biti vidljiv u inspectoru. Zbrajanje je u Start-u.

    public int broj1;
    public int broj2;
    public int rez;

    private void Start()
    {
        rez = broj1 + broj2;
    }
}
