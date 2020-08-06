﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float minTimeBtwSpawns;
    public float decrease;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
    if(player!=null){
            if(timeBtwSpawns <=0){
                // for spawning enemies we first need to select an
                // enemy and then a spawning point
                Transform randomSpawnPoint = spawnPoints[Random.Range(0,spawnPoints.Length)];
                GameObject randomEnemy = enemies[Random.Range(0,enemies.Length)];
                Instantiate(randomEnemy,randomSpawnPoint.position,Quaternion.identity);
                
                if(startTimeBtwSpawns>minTimeBtwSpawns){

                    startTimeBtwSpawns-=decrease;

                }
                timeBtwSpawns=startTimeBtwSpawns;

            }else{
                timeBtwSpawns-=Time.deltaTime;
                // print(Time.deltaTime);
                // print("TimeBtwSpawns"+timeBtwSpawns);
            }
        }
    }
}
