using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerScore;
    [SerializeField] GameSettings gameSettings;

    public static int gameScore;
    public static bool isPlayerDeath;
    public static float gameSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        isPlayerDeath = false;
        gameSpeed = gameSettings.initialGameSpeed; 
    }

    // Update is called once per frame
    void Update()
    {
        if ( isPlayerDeath )
        {
            PlayerReadyDetector.IsPlayerReady = false;
        }
        
        playerScore.text = gameScore.ToString();
    }
}
