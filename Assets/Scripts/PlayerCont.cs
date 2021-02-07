using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerCont : NetworkBehaviour
{
    public float movementSpeed = 10.0f;

    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f) * Time.deltaTime * movementSpeed;
            transform.position = transform.position + movement;
        }
    }

    private void Update()
    {
        HandleMovement();
    }
}
