using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyMovement : MonoBehaviour
{
    public static float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    private void Start()
    {
        target = waypoints.points[0]; //Set first waypoint as target
        speed = 10f;
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World); //Move towards target

        if(Vector3.Distance(transform.position, target.position) <= 0.2f) //Waypointreached
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint() //Set next waypoint as target
    {

        if(wavepointIndex >= waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("youlose");
            return;
        }

        wavepointIndex++;
        target = waypoints.points[wavepointIndex];
    }
}
