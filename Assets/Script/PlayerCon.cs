using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCon : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public GameObject StartPiont;
    
    private float horizontalInput;
    private float frowardInput ;
    private bool isjump = false;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputAction Move = InputSystem.actions.FindAction("Move");
        InputAction Jump = InputSystem.actions.FindAction("Jump");
        horizontalInput = Move.ReadValue<Vector2>().x;
        frowardInput = Move.ReadValue<Vector2>().y;

        
        transform.Translate(frowardInput * speed * Time.deltaTime * Vector3.forward);
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        if(Input.GetKeyDown(KeyCode.Space) && isjump == false)
        {
            rb.AddForce(Vector3.up * jumpForce);
            isjump = true;
   
        }

        if (transform.position.y < -7)
        {
           transform.position = StartPiont.transform.position;
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isjump = false;
        }
    }
}
