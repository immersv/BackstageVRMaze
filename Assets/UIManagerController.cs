using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerController : MonoBehaviour
{
    public GameObject mainCanvas, rulesCanvas;
    // Start is called before the first frame update
    
    public void ToggleCanvas()
    {
        mainCanvas.SetActive(false);
        rulesCanvas.SetActive(true);
    }
    public void GoToPlayScene(int value)
    {
        SceneManager.LoadScene(value);
    }
}
