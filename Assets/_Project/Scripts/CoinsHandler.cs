using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsHandler : MonoBehaviour
{
    [SerializeField] private int _coinsAmount;

    public int CoinsAmount {  get => _coinsAmount; set => _coinsAmount = value; }
}
