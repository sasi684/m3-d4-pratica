using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int _damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LifeController lifeController = collision.GetComponent<LifeController>();
            if (lifeController)
            {
                lifeController.TakeDamage(_damage);
                Destroy(gameObject);
            }
        }
    }
}
