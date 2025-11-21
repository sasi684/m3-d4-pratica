using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int _health;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            _health = 0;
            Debug.Log("Il giocatore e' stato sconfitto");
            Destroy(gameObject);
        }
        else
            Debug.Log($"Il giocatore {gameObject.name} ha adesso {_health}hp");
    }

    public void TakeHeal(int amount)
    {
        if (_health > 0)
        {
            _health += amount;
            Debug.Log($"Il giocatore {gameObject.name} ha adesso {_health}hp");
        }
        else
        {
            Debug.Log("Il giocatore e' stato sconfitto");
            Destroy(gameObject);
        }
    }
}
