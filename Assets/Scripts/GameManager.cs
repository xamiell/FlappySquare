using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerScore;
    [SerializeField] GameSettings gameSettings;
    [SerializeField] SceneLoader sceneLoader;

    public static int gameScore;
    public static bool isPlayerDeath;
    public static float gameSpeed;

    // Start is called before the first frame update
    void Start()
    {
        isPlayerDeath = false;
        gameSpeed = gameSettings.initialGameSpeed;

        // Reset static property score
        gameScore = default;
    }

    // Update is called once per frame
    void Update()
    {
        if ( isPlayerDeath )
        {
            PlayerReadyDetector.IsPlayerReady = false;
            StartCoroutine( sceneLoader.LoadGameOverScreen() );
        }
        
        playerScore.text = gameScore.ToString();
    }
}
