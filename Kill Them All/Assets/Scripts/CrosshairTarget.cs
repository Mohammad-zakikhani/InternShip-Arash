using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairTarget : MonoBehaviour
{
    public Camera cam;
    Ray ray;
    RaycastHit hit;
    public bool isAimingAir;

    private void Update()
    {
        ray.origin = cam.transform.position;
        ray.direction = cam.transform.forward;
        if(Physics.Raycast(ray, out hit))
        {
            isAimingAir = false;
        }
        else
        {
            isAimingAir = true;
        }
        transform.position = hit.point;
    }
}
