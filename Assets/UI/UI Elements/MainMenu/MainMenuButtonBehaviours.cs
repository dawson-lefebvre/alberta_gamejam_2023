using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuButtonBehaviours : MonoBehaviour
{
    [SerializeField] GameObject mainMenuUI;
    [SerializeField] GameObject howToPlayUI;
    [SerializeField] GameObject creditsUI;
    [SerializeField] EventSystem eventSystem;
    public void Quit()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        //Will load first level or possibly level select screen
        SceneManager.LoadScene(1);
    }

    [SerializeField] GameObject HTPBackButton;
    public void HowToPlay()
    {
        mainMenuUI.SetActive(false);
        howToPlayUI.SetActive(true);
        eventSystem.SetSelectedGameObject(HTPBackButton);
    }

    [SerializeField] GameObject CreditsBackButton;
    public void Credits()
    {
        mainMenuUI.SetActive(false);
        creditsUI.SetActive(true);
        eventSystem.SetSelectedGameObject(CreditsBackButton);
    }

    [SerializeField] GameObject MainMenuPlayButton;
    public void BackToMenu()
    {
        mainMenuUI.SetActive(true);
        howToPlayUI.SetActive(false);
        creditsUI.SetActive(false);
        eventSystem.SetSelectedGameObject(MainMenuPlayButton);
    }
}
