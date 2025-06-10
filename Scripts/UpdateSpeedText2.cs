using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UpdateSpeedText2 : MonoBehaviour
{

    public Slider speedSlider;
    public TextMeshProUGUI speedText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Snelheid: " + speedSlider.value.ToString("0");
    }
}
