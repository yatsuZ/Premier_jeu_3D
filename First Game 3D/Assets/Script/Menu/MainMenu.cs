using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartTuto()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoMainMenu()
    {
        string mainMenuSceneName = "Menu"; // Remplacez "MainMenu" par le nom de votre scène de menu principal
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void QuitGame()
    {
        Debug.Log("Quit\n");
        Application.Quit();
    }
}
