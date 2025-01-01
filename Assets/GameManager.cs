using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float arenaLowerBound = -10f;

    public Text scoreText;
    public Text winMessage;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
        winMessage.gameObject.SetActive(false);
    }

    // Add 100 points every time a Stable tile turns green
    public void AddPoints()
    {
        score += 100;
        scoreText.text = score.ToString();

        // End game when all tiles are green
        if (score == 3600)
        {
            EndGame();
        }
    }

    // Returns lower bound of arena
    public float GetArenaLowerBound()
    {
        return arenaLowerBound;
    }

    void EndGame()
    {
        // Display congratulations message
        winMessage.gameObject.SetActive(true);

        // Get player object
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        // Disable player object
        playerObject.SetActive(false);
    }
}