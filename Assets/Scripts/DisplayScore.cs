using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    // Configuration parameter
    TextMeshProUGUI scoreText;
    GameSession gameSession;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        SetScoreText();
    }

    private void SetScoreText()
    {
        Debug.Log(gameSession);
        scoreText.text = gameSession.GetScore().ToString();
    }
}
