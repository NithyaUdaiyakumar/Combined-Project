using UnityEngine;
using UnityEngine.UI;

public class SizeChanger : MonoBehaviour
{
    public GameObject cube;
    public Slider sizeSlider;

    void Start()
    {

        sizeSlider.onValueChanged.AddListener(ChangeCubeSize);
    }


    void ChangeCubeSize(float newSize)
    {
        if (cube != null)
        {
            cube.transform.localScale = Vector3.one * newSize;
        }
    }
}
