using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class CameraMove : MonoBehaviour
{
    private string mouseY = "Mouse Y";
    private string mouseX = "Mouse X";
    [SerializeField] const float speed = 0.01f;
    [SerializeField] const float zoomSpeed = 10.0f;
    [SerializeField]  const float rotationSpeed = 2.0f;

    bool locked = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            
            if(locked)
            {
                locked = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                locked = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

        if(!locked){
            Vector3 move = Vector3.zero;
            if(Input.GetKey(KeyCode.W))
            {
                move+=Vector3.forward*speed;
            }
            if(Input.GetKey(KeyCode.S))
            {
                move+=Vector3.back*speed;
            }
            if(Input.GetKey(KeyCode.A))
            {
                move+=Vector3.left*speed;
            }
            if(Input.GetKey(KeyCode.D))
            {
                move+=Vector3.right*speed;
            }
            if(Input.GetKey(KeyCode.Space))
            {
                move+=Vector3.up*speed;
            }
            if(Input.GetKey(KeyCode.LeftShift))
            {
                move+=Vector3.down*speed;
            }
            
            float mouseMoveY = Input.GetAxis(mouseY);
            float mouseMoveX = Input.GetAxis(mouseX);
            transform.RotateAround(transform.position, transform.right, mouseMoveY * -rotationSpeed);
            transform.RotateAround(transform.position, Vector3.up, mouseMoveX * rotationSpeed);
            transform.Translate(move);
        }
        
    }
}
