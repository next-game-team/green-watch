using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 4f;
	public float minZoom = 5f;
	public float maxZoom = 15f;

    private float currentZoom;

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        currentZoom = 500;
        cam.orthographicSize = currentZoom;
    }

    void Update()
    {
        Zoom();
    }

    private void Zoom()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
		currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        cam.orthographicSize = currentZoom;
    }
}
