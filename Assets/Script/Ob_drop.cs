using UnityEngine;

public class Ob_drop : MonoBehaviour
{
    private Rigidbody obj;
    

    void Start()
    {
        obj = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            obj.useGravity = true;
        }
        
    }
}
