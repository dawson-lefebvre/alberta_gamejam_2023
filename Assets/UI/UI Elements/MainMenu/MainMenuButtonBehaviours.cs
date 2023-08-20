using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonBehaviours : MonoBehaviour
{
    [SerializeField] GameObject mainMenuUI;
    [SerializeField] GameObject howToPlayUI;
    public void Quit()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        //Will load first level or possibly level select screen
        SceneManager.LoadScene(1);
    }

    public void HowToPlay()
    {
        mainMenuUI.SetActive(false);
        howToPlayUI.SetActive(true);
    }

    public void BackToMenu()
    {
        mainMenuUI.SetActive(true);
        howToPlayUI.SetActive(false);
    }
}
