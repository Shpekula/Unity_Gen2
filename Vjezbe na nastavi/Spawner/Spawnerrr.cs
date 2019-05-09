using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawnerrr : MonoBehaviour
{
    public GameObject[] enemies; //objekti enemya
    public Transform[] spawn_points; //spawn pointovi enemya
    int enemy_count;
    int spawn_count;
    public float spawn_time = 4; //vrijeme između stvaranja enemya (mjenja se)
    float spawn_time_start; //početno vrijeme

    GameObject enemy_clone;

    void Start()
    {  
        spawn_time_start = spawn_time; //koliko je vrijme za spawn
        enemy_count = enemies.Length; //učitamo koliko imamo ukupno različith enemya
        Debug.Log("enemia je: " + enemy_count);
        spawn_count = spawn_points.Length; //učitamo koliko imamo različitih spawn pointova
        Debug.Log("spawna je: " + spawn_count);
    }

    void Update()
    {
        spawn_time -= Time.deltaTime;
        if(spawn_time <= 0)
        {
            Debug.Log("Spawnaj");
            enemy_clone = Instantiate(enemies[Random.Range(0, enemy_count)], spawn_points[Random.Range(0, spawn_count)].position, Quaternion.identity);
            spawn_time = spawn_time_start; //resetiraj vrijeme
        }
    }
}
