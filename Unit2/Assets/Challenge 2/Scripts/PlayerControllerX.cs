using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float attackSpeed = 1;
    private float attackDelay = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, after the delay ,spawn dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > attackDelay)
        {
            attackDelay = Time.time + attackSpeed; // Change the delay to the last time a dog was spawned
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
