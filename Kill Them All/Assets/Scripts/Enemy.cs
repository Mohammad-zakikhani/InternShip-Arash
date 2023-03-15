using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet" && enemyHealth > 0)
        {
            enemyHealth -= 1;
            Debug.Log(enemyHealth);
        }
        else if (collision.gameObject.tag == "Bullet" && enemyHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log(enemyHealth + "Else");
        }
    }
}
