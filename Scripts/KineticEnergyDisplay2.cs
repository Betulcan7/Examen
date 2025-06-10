using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KineticEnergyDisplay2 : MonoBehaviour
{

    public Slider speedSlider;
    public float massa = 1000f;
    public TextMeshProUGUI energyText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = speedSlider.value;
        float Ek = 0.5f * massa * v * v;
        energyText.text = "Ek = " + Ek.ToString("0") + " J";
    }
}
