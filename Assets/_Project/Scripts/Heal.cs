using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private int _healAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LifeController lifeController = collision.GetComponent<LifeController>();
            if (lifeController)
            {
                lifeController.TakeHeal(_healAmount);
                Destroy(gameObject);
            }
        }
    }
}
