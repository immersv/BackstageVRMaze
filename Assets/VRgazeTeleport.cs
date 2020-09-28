using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRgazeTeleport : MonoBehaviour
{
    public Image gazeImage;
    public float gazeTimer;
    public bool gazeStatus;
    public float gazeTotaltime=2f;
   

    // Update is called once per frame
    void Update()
    {
        if (gazeStatus)
        {
            gazeTimer += Time.deltaTime;
            gazeImage.fillAmount = gazeTimer / gazeTotaltime;
        }
        else
        {

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
        gazeImage.fillAmount = gazeTimer / gazeTotaltime;
    }
}
