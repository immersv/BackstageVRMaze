using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonTeleport : MonoBehaviour
{
    private Transform mainCam;
    private Ray ray;
    private RaycastHit raycastHit;
    private LayerMask waypointLayer;
    private GameObject currentWaypoint;
    // Start is called before the first frame update
    void Awake()
    {
        mainCam = Camera.main.transform;
        waypointLayer = LayerMask.GetMask("Waypoint");

    }

    // Update is called once per frame
    void Update()
    {
        OnWaypointRaycast();
    }

    private void OnWaypointRaycast()
    {
        ray = new Ray(mainCam.position, mainCam.forward);
        if (Physics.Raycast(ray, out raycastHit, 20f,waypointLayer))
        {
            GameObject hitObj = raycastHit.collider.gameObject;
            if (hitObj !=currentWaypoint)
            {
                if (currentWaypoint != null)
                {
                    ResetWaypoint();
                }
                OnTargetWaypoint(hitObj);
            }
            if (Input.GetMouseButtonUp(0))
            {
                transform.position = currentWaypoint.transform.position;
                transform.rotation = currentWaypoint.transform.rotation;
            }

            
        }
        else if (currentWaypoint != null)
        {
            ResetWaypoint();
        }
    }

    private void OnTargetWaypoint(GameObject objHit)
    {
        objHit.GetComponent<WayPointBehaviour>().OnTargeted();
        currentWaypoint = objHit;
    }

    private void ResetWaypoint()
    {
        currentWaypoint.GetComponent<WayPointBehaviour>().OnDisabled();
        currentWaypoint = null;
    }
}
