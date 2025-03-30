using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_4 : MonoBehaviour
{
    public float health = 100f;
    public float movementSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}