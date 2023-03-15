using UnityEngine;

public class Aim : MonoBehaviour
{
    public Transform raycastOrigin;
    public Transform raycastDestination;
    Ray ray;
    RaycastHit hit;

    private void Update()
    {
        ray.origin = raycastOrigin.position;
        ray.direction = raycastDestination.position - raycastOrigin.position;

        Physics.Raycast(ray, out hit);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.red, 1.0f);
        }
    }
}
