using UnityEngine;

public class DoosImpact3 : MonoBehaviour
{
    public float krachtFactor = 0.1f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Auto"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Rigidbody autoRB = collision.gameObject.GetComponent<Rigidbody>();

            float massa = autoRB.mass;
            float snelheid = autoRB.linearVelocity.magnitude;
            float ek = 0.5f * massa * snelheid * snelheid;

            Vector3 forceDir = collision.contacts[0].normal * -1;
            rb.AddForce(forceDir * ek * krachtFactor, ForceMode.Impulse);
        }
    }

}
