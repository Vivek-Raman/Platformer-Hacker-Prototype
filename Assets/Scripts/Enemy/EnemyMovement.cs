using System;
using System.Collections.Generic;
using Extras.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public GameObject associatedPlatform;

    private List<Vector3> waypointPositions = null;
    private int currentWaypointIndex = 0;
    private NavMeshAgent agent = null;

    private void Awake()
    {
        agent = this.GetComponent<NavMeshAgent>();
        if (this.transform.GetChild(0).childCount <= 0)
        {
            this.agent.enabled = false;
            this.enabled = false;
        }
        else
        {
            RecalculateWaypointPositions();

            agent.SetDestination(waypointPositions[currentWaypointIndex]);
        }
    }

    private void Update()
    {
        if (this.transform.position.Approximately(waypointPositions[currentWaypointIndex]))
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypointPositions.Count;
            agent.destination = waypointPositions[currentWaypointIndex];
        }
    }

    private void RecalculateWaypointPositions()
    {
        GameObject waypointParent = GameObject.Find("Waypoint Parent");
        if (waypointParent == null)
        {
            waypointParent = new GameObject("Waypoint Parent");
        }

        Transform currentWaypointParent = this.transform.GetChild(0);
        waypointPositions = new List<Vector3>();
        while (currentWaypointParent.childCount > 0)
        {
            Transform waypoint = currentWaypointParent.GetChild(0);
            waypointPositions.Add(waypoint.position);
            waypoint.SetParent(waypointParent.transform);
        }
    }
}
