using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Renderer prefab;
    // Start is called before the first frame update
    void Start()
    {
        prefab = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        prefab.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
