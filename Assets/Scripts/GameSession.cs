using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    [Range(0.1f, 10f)] [SerializeField] private float gameSpeed = 1f;
    [SerializeField] private int pointsPerBlockDestroyed = 50;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI gameSpeedText;

    //state variables
    [SerializeField] private int currentScore = 0;

    private AutoPlay theAutoPlay;
    
    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameSpeedIncrease();
        }
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed ;
        scoreText.text = currentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public void gameSpeedIncrease()
    {
        if (gameSpeed < 10)
        {
            gameSpeed++;
            gameSpeedText.text = gameSpeed.ToString() + "x";
        }
        else
        {
            gameSpeed = 1;
            gameSpeedText.text = gameSpeed.ToString() + "x";
        }
    }

}
