using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerController : MonoBehaviour
{
    public GameObject mainCanvas, rulesCanvas;
    // Start is called before the first frame update
    void Start()

    {

        ToggleCanvas();

    }


    public void ToggleCanvas()
    {
        mainCanvas.SetActive(!mainCanvas.activeSelf);
        rulesCanvas.SetActive(!rulesCanvas.activeSelf);
    }
    public void GoToPlayScene(int value)
    {
        SceneManager.LoadScene(value);
    }
}
