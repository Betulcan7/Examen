using UnityEngine;
using TMPro;
public class EnergyCalculator3 : MonoBehaviour
{

    public Rigidbody auto;
    public TMP_Text ekText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float m = auto.mass;
        float v = auto.linearVelocity.magnitude;

        float ek = 0.5f * m * v * v;
        ekText.text = "Ek = " + ek.ToString("F2") + " J";
    }
}
