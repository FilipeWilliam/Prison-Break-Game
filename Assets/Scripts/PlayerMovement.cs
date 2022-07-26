using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
  Vector2 moveInput;
  Rigidbody2D myRigidbody;
  [SerializeField] float runSpeed = 5f;

  void Awake()
  {
    myRigidbody = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    Run();
  }

  void OnMove(InputValue value)
  {
    moveInput = value.Get<Vector2>();
  }

  void Run()
  {
    Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, myRigidbody.velocity.y);
    myRigidbody.velocity = playerVelocity;
  }
}