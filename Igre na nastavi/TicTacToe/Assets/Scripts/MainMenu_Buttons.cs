using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Buttons : MonoBehaviour
{
    public int brojRazine = 0;

    public void ClickStart() //Nova scena
    {
        SceneManager.LoadScene(brojRazine);
    }

    public void ClickExit() //Izlaz iz aplikacije
    {
        Application.Quit();
    }

    public void OpenWeb() //Otovri link (mora biti http://)
    {
        Application.OpenURL("http://inkubator-pismo.eu/");
    }

    public void CallPhone() //Zovi na telephone (mora biti tel://)
    {
        Application.OpenURL("tel://091921554");
    }

    public void OpenMail() //Otvori mail (mora biti mailto:)
    {
        Application.OpenURL("mailto:dominik@inkubator-pismo.eu");
    }
}
