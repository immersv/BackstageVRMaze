using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ThirdPersonTeleport : MonoBehaviour
{
    //public varialbles
    public GameObject ethenPlayer;
    //private variables
    private Transform mainCam;
    private Ray ray;
    private RaycastHit raycastHit;
    private LayerMask layerMask;

    private void Awake()
    {
        mainCam = Camera.main.transform;
        layerMask = LayerMask.GetMask("Ground");
    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            OnPointClickRaycast();
        }
    }

    private void OnPointClickRaycast()
    {
        ray = new Ray(mainCam.position, mainCam.forward);
        if(Physics.Raycast(ray,out raycastHit, Mathf.Infinity, layerMask))
        {
            NavMeshHit navMeshHit;
            if(NavMesh.SamplePosition(raycastHit.point,out navMeshHit, 0.5f, NavMesh.AllAreas))
            {
                ethenPlayer.transform.position = navMeshHit.position;
                
            }
        }

    }
}
