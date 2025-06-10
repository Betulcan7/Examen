using UnityEngine;
using UnityEngine.UI;
public class PlayerController2 : MonoBehaviour
{
    public Slider speedSlider;

    void Update()
    {
        float speed = speedSlider.value;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
