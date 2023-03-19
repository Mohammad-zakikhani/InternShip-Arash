using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 6;
    public Bullet Bullet;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet" && enemyHealth > 0)
        {
            enemyHealth -= Bullet.Damage;
            Debug.Log(enemyHealth);
        }
        else if (collision.gameObject.tag == "Bullet" && enemyHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log(enemyHealth + "Died");
        }
    }
}
