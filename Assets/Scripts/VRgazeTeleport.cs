﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRgazeTeleport : MonoBehaviour
{
    public Image gazeImage;
    public float gazeTimer;
    public bool gazeStatus=false;
    public float gazeTotaltime=2f;
    [SerializeField]
    int distanceToRay ;
    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if (gazeStatus)
        {
            gazeTimer += Time.deltaTime;
            gazeImage.fillAmount = gazeTimer / gazeTotaltime;
        }
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray, out hit, distanceToRay))
        {
            if(gazeImage.fillAmount == 1 && hit.transform.CompareTag("Teleport"))
            {
                hit.transform.gameObject.GetComponent<TeleportPlayer>().OnTeleportPlayer();
               // gazeStatus = false;
            }
        }
        
    }

   public void OnGazeEnter()
    {
        gazeStatus = true;
    }
    public void OnGazeExit()
    {
        gazeStatus = false;
        gazeTimer = 0;
        gazeImage.fillAmount = 0;
    }
}
