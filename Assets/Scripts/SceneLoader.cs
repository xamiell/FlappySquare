using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] AudioClip clickButtonSound;
    [SerializeField] AudioSource musicBackground;

    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;

        if ( FindObjectsOfType( GetType() ).Length > 1)
        {
            Destroy( gameObject );
        }
        else
        {
            DontDestroyOnLoad( gameObject );
            DontDestroyOnLoad( musicBackground );
        }
    }

    public void OnStartGame()
    {
        PlaySound();
        SceneManager.LoadScene("Main_Game");
    }

    private void PlaySound()
    {
        AudioSource.PlayClipAtPoint(clickButtonSound, _mainCamera.transform.position);
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
}
