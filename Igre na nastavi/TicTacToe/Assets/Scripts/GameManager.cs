using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Lista sa poljima")] //Ovako stavljamo boldani tekst u inspectoru
    public Text[] spaceList; //Lista polja (tekstualnih na buttonu)

    [Header("Game over Panel (UI)")]
    public GameObject gameOver;
    public Text gameOver_text;

    public int moves = 0; //Koliko poteza imamo

    string side; //Može biti vrijednost "X" ili "O"

    void Start() //Dodjeli vrijednost
    {
        gameOver.SetActive(false); //gasimo game over za svaki slucaj
        side = "X";
        moves = 0;
    }

    public void ChangeSide() //Mjenja tko je "na potezu"
    {
        if(side == "X")
        {
            side = "O";
        }
        else
        {
            side = "X";
        }
    }

    public void EndTurn() //Metoda sa uvijetima za kraj igre ili nastavak
    {
        if(spaceList[0].text == side && spaceList[1].text == side && spaceList[2].text == side)
        {
            GameOver();
        }
        else if (spaceList[3].text == side && spaceList[4].text == side && spaceList[5].text == side)
        {
            GameOver();
        }
        else if (spaceList[6].text == side && spaceList[7].text == side && spaceList[8].text == side)
        {
            GameOver();
        }
        else if (spaceList[0].text == side && spaceList[3].text == side && spaceList[6].text == side)
        {
            GameOver();
        }
        else if (spaceList[1].text == side && spaceList[4].text == side && spaceList[7].text == side)
        {
            GameOver();
        }
        else if (spaceList[2].text == side && spaceList[5].text == side && spaceList[8].text == side)
        {
            GameOver();
        }
        else if (spaceList[0].text == side && spaceList[4].text == side && spaceList[8].text == side)
        {
            GameOver();
        }
        else if (spaceList[2].text == side && spaceList[4].text == side && spaceList[6].text == side)
        {
            GameOver();
        }
        else if(moves >= 9) //Jer je polja 9, dakle max 9 poteza
        {
            gameOver.SetActive(true);
            gameOver_text.text = "Tie!";
        }

        ChangeSide();
    }

    void GameOver()
    {
        gameOver.SetActive(true);
        gameOver_text.text = side + " wins!";
    }

    public string GetSide()
    {
        return side;
    }
}
