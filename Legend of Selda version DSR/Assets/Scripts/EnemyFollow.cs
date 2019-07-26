using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Adds to the Green Slime Enemy the capability of following the player
/// As there is no Nav Mesh Agent components in 2D game environment,
/// we could not use the AI library for implementing the persecution.
/// </summary>
public class EnemyFollow : MonoBehaviour
{
    public float speed; //how fast the enemy runs after the player
    public float stoppingDistance; 

    private PlayerController player; 
    private Transform target; //the game object our enemy is chasing after

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        target = player.GetComponent<Transform>();
    }

    void Update()
    {
        /*Enemy going after the player with bad intentions,
        moving from its position towards the target's position at a certain speed */

        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        //Enemy going after the player just to scare him
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            //If the enemy is not close to the player, continue moving
            //Move towards the player
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
