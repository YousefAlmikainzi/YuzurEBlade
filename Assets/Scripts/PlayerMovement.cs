using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    float gravity = -9.8f;
    Rigidbody rb;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * 2.0f, gravity, Input.GetAxis("Vertical") * 2.0f);
        
        controller.Move(movement * Time.deltaTime);
    }
}
