using UnityEngine;

/* Makes the camera follow the player */

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;          // offset of camera
    public float zoomSpeed = 4f;    // ZoomSpeed
    public float minZoom = 5f;      // minimum Zoom
    public float maxZoom = 15f;     // maximum Zoom

    public float pitch = 3f;        // player heigth
    public float yawSpeed = 100f;   // rotation around camera
    
    private float currentZoom = 8f; // 
    private float currentYaw = 0f;    // 

    void Update()
    {
        //get position of mousewheel and set Zoom
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;

        // locks value between min and maxZoom
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        //check for a/d or left/right keys
        currentYaw -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
    }

    void LateUpdate()
    {
        // use mousewheel to zoom in and out
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);
       
        // use a or d to rotate around
        transform.RotateAround(target.position, Vector3.up, currentYaw);
    }

}