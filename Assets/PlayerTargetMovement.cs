using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTargetMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject groundPlane;
    private Transform mainCam;
    private Ray ray;
    private RaycastHit raycastHit;
    void Awake()
    {
        mainCam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(mainCam.position, mainCam.forward * 75, Color.red);
        if (Input.GetMouseButtonUp(0))
        {
            OnClickRaycast();
        }
         
    }

    private void OnClickRaycast()
    {
        ray = new Ray(mainCam.position,mainCam.forward);
        if(Physics.Raycast(ray, out raycastHit, Mathf.Infinity))
        {
            GameObject obj = raycastHit.collider.gameObject;
            if (obj == groundPlane)
            {
                transform.position = raycastHit.point;
            }
        }
    }
}
