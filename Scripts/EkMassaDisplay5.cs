using UnityEngine;
using TMPro;

public class EkMassaDisplay5 : MonoBehaviour
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
        float v = 10f;
            float ek = 0.5f * m * v * v;
        ekText.text = "Ek (massa) = " + ek.ToString("F2") + " J";
       

    }
}
