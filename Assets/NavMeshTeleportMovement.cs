using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshTeleportMovement : MonoBehaviour
{
    public GameObject ethenPlayer;
    private LayerMask layerMask;
    private Transform mainCam;
    private Ray ray;
    private RaycastHit raycastHit;
    // Start is called before the first frame update
    void Awake()
    {
        mainCam = Camera.main.transform;
        layerMask = LayerMask.GetMask("layerPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            OnClickNavMeshRaycast();
        }
    }

    private void OnClickNavMeshRaycast()
    {
        ray = new Ray(mainCam.position, mainCam.forward);
        if(Physics.Raycast(ray,out raycastHit, Mathf.Infinity, layerMask))
        {
            NavMeshHit navMeshHit;

            if(NavMesh.SamplePosition(raycastHit.point, out navMeshHit, 0.5f, NavMesh.AllAreas))
            {
                ethenPlayer.transform.position = navMeshHit.position;
            }
        }
    }
}
