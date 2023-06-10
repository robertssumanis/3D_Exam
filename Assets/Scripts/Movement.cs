using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Vector3 PlayerMovementInput;

    [SerializeField] Transform cameraTransform;
    Vector2 look;

    Rigidbody rb;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // hide cursor
        rb = this.GetComponent<Rigidbody>();
    }


    void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        cameraLook();
        playerMovement();
    }


    void playerMovement()
    {
        Vector3 MoveVector = cameraTransform.TransformDirection(PlayerMovementInput) * 5;
        rb.velocity = new Vector3(MoveVector.x, rb.velocity.y, MoveVector.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }

    void cameraLook()
    {
        look.x += Input.GetAxis("Mouse X");
        look.y += Input.GetAxis("Mouse Y");

        look.y = Mathf.Clamp(look.y, -90f, 90f); //stop infinite vetical camera rotation

        cameraTransform.localRotation = Quaternion.Euler(-look.y, 0, 0); //vertical camera rotation
        transform.localRotation = Quaternion.Euler(0, look.x, 0); // horizontal camera rotation
    }
}
