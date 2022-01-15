using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] 
    private Transform cameraArm;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAround();
    }



    private void LookAround()
    { 
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")); 
        Vector3 camAngle = cameraArm.rotation.eulerAngles; 
        cameraArm.rotation = Quaternion.Euler(camAngle.x - mouseDelta.y, camAngle.y + mouseDelta.x, camAngle.z); 
    }

}
