using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 0.5f;
    float horizontalMove = 0f;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
    }

    void FixedUpdate() {
        controller.Move(horizontalMove, false, false);
    }
}
