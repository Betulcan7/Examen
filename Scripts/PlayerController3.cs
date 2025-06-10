using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    public Rigidbody autoRigidbody;
    public float speed = 10f;

    
    private void Start()
    {
       
    }

    void FixedUpdate()
    {
        autoRigidbody.linearVelocity = transform.forward * speed;
        
        
    }
}
