using UnityEngine;

public class Aim : MonoBehaviour
{
    public Transform raycastOrigin;
    public Transform raycastDestination;
    Ray ray;
    RaycastHit hit;

    public GameObject bulletPrefab;
    public float bulletSpeed = 30000f;

    AudioSource shootingSound;

    private void Start()
    {
        shootingSound = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        ray.origin = raycastOrigin.position;
        ray.direction = raycastDestination.position - raycastOrigin.position;

        Physics.Raycast(ray, out hit);

        //if (Input.GetMouseButtonDown(0))
        //{
        //Debug.DrawLine(ray.origin, hit.point, Color.red, 1.0f);
        //}

        if (Input.GetMouseButtonDown(0))
        {
            shootingSound.Play();
            var bullet = Instantiate(bulletPrefab, raycastOrigin.position, raycastOrigin.rotation);
            bullet.GetComponent<Rigidbody>().velocity = raycastOrigin.forward * bulletSpeed * Time.deltaTime;
        }
    }
}
