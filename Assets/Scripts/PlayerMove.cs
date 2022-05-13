using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float movementSpeed =5f;
    [SerializeField] private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movementDirection.z++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementDirection.x--;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementDirection.z--;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementDirection.x++;
        }

        transform.LookAt(transform.position + movementDirection);
        characterController.Move(movementDirection * Time.deltaTime * movementSpeed);
    }
}
