using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    // [SerializeField] float speed = 20.0f;
    [SerializeField] float horsePower = 0;
    float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get user input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the car forwards and backwards
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Rotate the car
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
