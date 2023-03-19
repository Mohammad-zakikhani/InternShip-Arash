using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3.0f;
    public int Damage = 1;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
