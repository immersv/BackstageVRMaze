using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointBehaviour : MonoBehaviour
{
    public Color targetColor;
    public Color normalColor;

    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        mat.color = normalColor;
    }

    public void OnTargeted()
    {
        mat.color = targetColor;
    }
    public void OnDisabled()
    {
        mat.color = normalColor;
    }
}
