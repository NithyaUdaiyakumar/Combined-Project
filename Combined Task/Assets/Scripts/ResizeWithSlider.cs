using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ResizeWithSlider : MonoBehaviour
{
    private Slider sizeSlider;

    void Start()
    {
        // Find the slider in the scene (you can assign it explicitly if needed)
        sizeSlider = FindObjectOfType<Slider>();

        if (sizeSlider != null)
        {
            // Add a listener to handle slider value changes
            sizeSlider.onValueChanged.AddListener(OnSliderValueChanged);
        }
        else
        {
            Debug.LogError("No slider found in the scene. Please add one and ensure it is accessible.");
        }
    }

    void OnSliderValueChanged(float value)
    {
        // Adjust the size of the object based on the slider value
        transform.localScale = Vector3.one * value;
    }

    void OnDestroy()
    {
        if (sizeSlider != null)
        {
            // Remove the listener when the object is destroyed
            sizeSlider.onValueChanged.RemoveListener(OnSliderValueChanged);
        }
    }
}
