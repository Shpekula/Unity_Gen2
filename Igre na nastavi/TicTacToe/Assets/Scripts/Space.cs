using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Space : MonoBehaviour
{
    public Text btnText; //text od buttona
    Button btn; //button na sceni (polje) / space

    GameManager gameManager;

    void Start()
    {
        btn = GetComponent<Button>(); // uzmi komponentu buttona
        gameManager = FindObjectOfType<GameManager>(); // nadi gamemanager
    }

    public void SetSpace() // Metoda se poziva na klik buttona, mora se dodjeliti na OnClick() na button
    {
        btnText.text = gameManager.GetSide(); //Pozovi metodu getside
        btn.interactable = false; // Onemogućili smo daljnje interakcije s gumbom
        gameManager.moves += 1; //dodaj potez
        gameManager.EndTurn(); //Provjeri jel kraj igre ili se nastavlja
    }
}
