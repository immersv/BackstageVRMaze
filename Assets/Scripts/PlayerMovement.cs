using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BackstageVRApp
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        private CharacterController characterController;
        [SerializeField]
        private float moveSpeed=1.5f;
        private bool iswalking = false;
        [SerializeField]
        private bool comfortMode = false;
        // Start is called before the first frame update
        [SerializeField]
        private bool isRotating = false;
        [SerializeField]
        private float camRotateDegrees = 45f;
        void Awake()
        {
            characterController = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            //PlayerMoveForward();
            if (Input.GetMouseButtonUp(0))
                {
                iswalking = !iswalking;
                }
            if (iswalking)
            {
                PlayerMoveForward();
                
            }
               
            if(comfortMode && camRotateDegrees>0 && !iswalking)
            {
                OnCamRotateEnable();
            }

        }
        void PlayerMoveForward()
        {
            Vector3 playerComfortDirection = transform.forward * moveSpeed;
            Vector3 playerMoveDirection = Camera.main.transform.forward * moveSpeed;
            if (comfortMode == true)
            {
                characterController.SimpleMove(playerComfortDirection);
            }
            else
            {
                characterController.SimpleMove(playerMoveDirection); ;
            }
           
        }
        void OnCamRotateEnable()
        {
            float horizontalAxis = Input.GetAxis("Horizontal");
            if (horizontalAxis > 0)
            {
                CamSnapRotation(camRotateDegrees);
            }
            else if (horizontalAxis < 0)
            {
                CamSnapRotation(-camRotateDegrees);
            }
            else 
            {
                isRotating = false;
            }
        }

        void CamSnapRotation(float degrees)
        {
            if (!isRotating)
            {
                transform.Rotate(0, degrees, 0);
                isRotating = true;
            }
           
        }

    }
}

