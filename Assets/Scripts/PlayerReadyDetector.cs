using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerReadyDetector : MonoBehaviour
{
    public static bool IsPlayerReady = default;

    [SerializeField] TextMeshProUGUI warmText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Space ) && IsPlayerReady == false && GameManager.isPlayerDeath == false )
        {
            IsPlayerReady = true;

            // Remove warm text when player press space button and 
            // remove the animator component to stop the animation in the background.
            // Preserve memory.
            StopWarmText();

            // Auto-Jump event of the player after press Space Button.
            // Some Accion TODO
        }

        if ( GameManager.isPlayerDeath == true )
        {
            PlayWarmText();
        }
    }

    private void StopWarmText()
    {
        warmText.enabled = false;
        warmText.GetComponent<Animator>().enabled = false;
    }

    private void PlayWarmText()
    {
        warmText.text = "OH, YOU DIE!";
        warmText.GetComponent<Animator>().enabled = true;
        warmText.enabled = true;
    }
}
