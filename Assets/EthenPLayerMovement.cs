using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthenPLayerMovement : MonoBehaviour
{
    //this script will make you to move in navmesh spaceor movable space
    public GameObject groundPlane;
    private Transform mainCam;
    Ray ray;
    RaycastHit raycastHit;
    // Start is called before the first frame update
    void Awake()
    {
        mainCam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(mainCam.position, mainCam.forward*50,Color.red);
        if (Input.GetMouseButtonUp(0))
        {
            OnEthenRaycast();
        }
    }

    private void OnEthenRaycast()
    {
        ray = new Ray(mainCam.position, mainCam.forward);
        if(Physics.Raycast(ray, out raycastHit, Mathf.Infinity))
        {
           GameObject obj= raycastHit.collider.gameObject;
            if(obj== groundPlane)
            {
                transform.position = raycastHit.point;
            }
        }
    }
}
