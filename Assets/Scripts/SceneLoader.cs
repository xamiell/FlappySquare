using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] AudioClip clickButtonSound;
    [SerializeField] GameSettings gameSettings;
    
    public void OnStartGame()
    {
        PlaySound();
        SceneManager.LoadScene("Main_Game");
    }

    private void PlaySound()
    {
        // TODO
    }

    public void OnOptionsGame()
    {
        PlaySound();
    }

    public void OnBestScoresGame()
    {
        PlaySound();
    }

    public void OnQuitGame()
    {
        PlaySound();
        Application.Quit();
    }

    public void OnMainMenu()
    {
        PlaySound();
        SceneManager.LoadScene("Main_Menu");
    }

    public void GoToGameOverScreen()
    {
        SceneManager.LoadScene("GameOver");
    }

    public IEnumerator LoadGameOverScreen()
    {
        yield return new WaitForSeconds( gameSettings.timeBetewnTransitions );
        GoToGameOverScreen();
    }
}
