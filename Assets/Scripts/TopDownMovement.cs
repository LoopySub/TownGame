using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
   private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody2D;


    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;  // OnMoveEvent에 Move 라는 재료 추가
    }

    private void FixedUpdate() // 물리법칙, 이동을 할떄 픽스에넣음
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction) // OnMoveEvent에 Move 라는 재료 추가
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= 5;

        _rigidbody2D.velocity = direction;  
    }
}
