using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInteraction : MonoBehaviour
{
    public GameObject cube;
    public void OnPointerClick()
    {      
        //Get the Renderer component from the new cube
        var cubeRenderer = cube.GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.color = Color.black;
    }
    public void OnPointerEnter()
    {
        var cubeRenderer = cube.GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.color = Color.blue;
    }
    public void OnPointerExit()
    {
        var cubeRenderer = cube.GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.color = Color.green;
    }
}
