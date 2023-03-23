using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 3;
    public Bullet Bullet;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet" && enemyHealth > 1)
        {
            enemyHealth -= Bullet.Damage;
            Debug.Log(enemyHealth);
        }
        else if (collision.gameObject.tag == "Bullet" && enemyHealth <= 1)
        {
            animator.enabled = true;
            Destroy(gameObject, 0.5f);
            Debug.Log("Died");
        }
    }
}
