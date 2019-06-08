using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataLoader : MonoBehaviour
{
    [SerializeField] GameSettings gameSettings;
    [SerializeField] TextMeshProUGUI actualScoreText;
    [SerializeField] TextMeshProUGUI bestScoreText;
    [SerializeField] TextMeshProUGUI gameOverMessageText;

    // Start is called before the first frame update
    void Start()
    {
        actualScoreText.text = LoadActualScore();
        gameOverMessageText.text = gameSettings.gameOverMessage;
        bestScoreText.text = LoadBestScore();
    }

    private string LoadActualScore()
    {
        return $"Your score: { GameManager.gameScore.ToString() }";
    }

    private string LoadBestScore()
    {
        // TODO GET DATA FROM DATA BASE
        return "Best score: 99999";
    }
}
