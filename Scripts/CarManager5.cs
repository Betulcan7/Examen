using UnityEngine;
using UnityEngine.UI;
public class CarManager5 : MonoBehaviour
{

    public Rigidbody auto;
    public Slider massSlider;
    public Slider speedSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        auto.mass = massSlider.value;
        auto.linearVelocity = transform.forward * speedSlider.value;
    }
}
