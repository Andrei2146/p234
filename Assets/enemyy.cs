using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    
    [SerializeField] private GameObject[] monster;

    
    private int currentMonsterIndex = 0;

    // Hur snabbt mönstern går
    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        // Kollar om distansen mellan enemyn och waypointen är mindre än 0.1
        if (Vector2.Distance(monster[currentMonsterIndex].transform.position, transform.position) < 0.1f)
        {
            
            currentMonsterIndex++;

            
            if (currentMonsterIndex >= monster.Length)
            {
                
                currentMonsterIndex = 0;
            }
        }

        // Flytta enemyn till waypoint
        transform.position = Vector2.MoveTowards(transform.position, monster[currentMonsterIndex].transform.position, Time.deltaTime * speed);
    }
}