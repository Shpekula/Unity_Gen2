using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zadatak9 : MonoBehaviour
{
    //Napisati skriptu za Rigidbody koji na space reagirati da se gasi gravity i 
    //kada padne i dotakne drugi objekt učita sljedeću scenu

    Rigidbody rb;
    Scene scene;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(rb.useGravity == true)
            {
                rb.useGravity = false;
            }
            else
            {
                rb.useGravity = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
}