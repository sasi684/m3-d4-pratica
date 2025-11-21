using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CoinsHandler coinsHandler = collision.GetComponent<CoinsHandler>();
            if (coinsHandler)
            {
                coinsHandler.CoinsAmount += _coins;
                Debug.Log($"Il giocatore {collision.name} ha adesso {coinsHandler.CoinsAmount} monete.");
                Destroy(gameObject);
            }
        }
    }
}
