using UnityEngine;

public class Orientation : MonoBehaviour
{
    public Vector2 rotation;
    public float sensitivity = 5f;

    public GameObject playerObj;
    public GameObject gun;
    private Transform playerTransform;

    public Transform crosshairTarget;
    public Camera cam;
    Ray ray;
    RaycastHit hit;
    public CrosshairTarget CrosshairTarget;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor
    }

    private void Update()
    {
        rotation.x += Input.GetAxis("Mouse X") * sensitivity;
        rotation.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-rotation.y, 0, 0);

        playerTransform = playerObj.GetComponent<Transform>();
        playerTransform.localRotation = Quaternion.Euler(0, rotation.x, 0);

        playerTransform = gun.GetComponent<Transform>();

        if(CrosshairTarget.isAimingAir == true)
        {
            playerTransform.localRotation = Quaternion.Euler(-rotation.y, 0, 0);
        }
        else
        {
            playerTransform.LookAt(crosshairTarget);
        }
    }
}
