using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    private uint bestScoreAll = Controllermod3.bestScore;
    public Text bestScore;
    private void Update()
    {
        if(bestScoreAll.ToString() != null)
        bestScore.text = bestScoreAll.ToString();
    }
    public GameObject bottonsMenu;
    public GameObject bottonsSettings;
    public GameObject bottonsInfo;
    public GameObject bottonsExit;

    public void ShowMenu()
    {
        bottonsMenu.SetActive(true);
        bottonsSettings.SetActive(false);
        bottonsInfo.SetActive(false);
        bottonsExit.SetActive(false);
    }

    public void ShowSettings()
    {
        bottonsMenu.SetActive(false);
        bottonsSettings.SetActive(true);
        bottonsInfo.SetActive(false);
        bottonsExit.SetActive(false);
    }
    public void ShowInfo()
    {
        bottonsMenu.SetActive(false);
        bottonsSettings.SetActive(false);
        bottonsInfo.SetActive(true);
        bottonsExit.SetActive(false);
    }
    public void ShowExit()
    {
        bottonsMenu.SetActive(false);
        bottonsSettings.SetActive(false);
        bottonsInfo.SetActive(false);
        bottonsExit.SetActive(true);
    }
    
    public void ExidGame()
    {
        Application.Quit();
        Debug.LogWarning("My game has closed :(");
    }

    public void NewGameLoadScens()
    {
        //Application.LoadLevel("SceneGame");
        SceneManager.LoadScene("SceneGame");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("SceneMenu");
    }

}
