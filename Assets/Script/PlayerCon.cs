using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerCon : MonoBehaviour
{
    public int maxHp = 3 ; 
    public int currentHp;
    public int currentMap;
    public float speed;
    public GameObject respawnPoint;
    public float jumpAcc = 5f;
    public float jumpForce;
    
    private float horizontalInput;
    private float frowardInput ;
    private bool isjump = false;



    private Rigidbody rb;

    private void Awake()
    {
        currentHp = maxHp;
    }

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
        
        CalForce();
        if(Input.GetKeyDown(KeyCode.Space) && isjump == false)
        {
            rb.AddForce(Vector3.up * jumpForce);
            isjump = true;
   
        }

        if (transform.position.y < -7)
        {
           transform.position = respawnPoint.transform.position;
           currentHp -= 1;
        }

        if (currentHp <= 0)
        {
            SceneManager.LoadSceneAsync(2);
        }

    }
    
    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground")||other.gameObject.CompareTag("SavePoint"))
        {
            isjump = false;
        }
    }

    private void CalForce()
    {
        jumpForce = rb.mass * jumpAcc;
    }    

}
