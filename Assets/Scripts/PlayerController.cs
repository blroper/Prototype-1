using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float turnSpeed;
    [SerializeField] private InputAction moveAction;
    [SerializeField] private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
       moveInput = moveAction.ReadValue<Vector2>();
       
       //We'll move the vehicle forward 
       transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

       transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * moveInput.x);
    }
}
