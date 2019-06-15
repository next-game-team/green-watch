using UnityEngine;

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

        if(Input.GetKey(KeyCode.W) || Input.mousePosition.y >= Screen.height - camBorderThickness)
        {
            pos.y += camMoveSpeed * Time.deltaTime;
        } 
        if(Input.GetKey(KeyCode.S) || Input.mousePosition.y <= camBorderThickness) {
            pos.y -= camMoveSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D) || Input.mousePosition.x >= Screen.width - camBorderThickness) {
            pos.x += camMoveSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A) || Input.mousePosition.x <= camBorderThickness) {
            pos.x -= camMoveSpeed * Time.deltaTime;
        }

        pos.x = Mathf.Clamp(pos.x, -camPosLimit.x, camPosLimit.x);
        pos.y = Mathf.Clamp(pos.y, -camPosLimit.y, camPosLimit.y);

        transform.position = pos;
    }
}
