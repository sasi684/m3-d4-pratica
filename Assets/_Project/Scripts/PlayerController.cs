using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    private Vector2 _direction;

    private void Awake()
    {
        if (_rb == null)
            _rb = GetComponent<Rigidbody2D>();
        if (_rb == null)
            Debug.LogError("Nessuna componente RigidBody2D trovata");
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        _direction = new Vector2(h, v);
    }

    private void FixedUpdate()
    {
        _rb.velocity = _direction * _speed;
    }
}
