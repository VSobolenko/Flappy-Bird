using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    private bool _isFullScreen = false;
    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Play pressed!");
    }

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
    public void FullScrennToggle()
    {
        _isFullScreen = !_isFullScreen;
        Screen.fullScreen = _isFullScreen;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
