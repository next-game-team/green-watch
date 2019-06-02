﻿using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float camMoveSpeed;
    public float camBorderThickness;
    public Vector2 camPosLimit;


    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 pos = transform.position;

        if(Input.mousePosition.y >= Screen.height - camBorderThickness)
        {
            pos.y += camMoveSpeed * Time.deltaTime;
        } 
        if(Input.mousePosition.y <= camBorderThickness) {
            pos.y -= camMoveSpeed * Time.deltaTime;
        }

        if(Input.mousePosition.x >= Screen.width - camBorderThickness) {
            pos.x += camMoveSpeed * Time.deltaTime;
        }

        if(Input.mousePosition.x <= camBorderThickness) {
            pos.x -= camMoveSpeed * Time.deltaTime;
        }

        pos.x = Mathf.Clamp(pos.x, -camPosLimit.x, camPosLimit.x);
        pos.y = Mathf.Clamp(pos.y, -camPosLimit.y, camPosLimit.y);

        transform.position = pos;
    }
}
