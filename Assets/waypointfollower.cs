using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointgo : MonoBehaviour
{
    [SerializeField] private GameObject[] platform;
    private int currentPlatformIndex = 0;

    [SerializeField] private float speed = 2f;

   
   // Gör att platformerna flyttar
    private void Update()
    {
        if (Vector2.Distance(platform[currentPlatformIndex].transform.position, transform.position) < .1f)
        {
            currentPlatformIndex++;
            if (currentPlatformIndex >= platform.Length)
            {
                currentPlatformIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, platform[currentPlatformIndex].transform.position, Time.deltaTime * speed);
    }
}
