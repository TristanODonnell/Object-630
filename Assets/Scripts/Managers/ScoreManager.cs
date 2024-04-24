using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int highScore;
    [SerializeField] private int score;

    public UnityEvent<int> OnScoreChanged = new UnityEvent<int>();
    public UnityEvent<int> OnNewHighScore = new UnityEvent<int>();
    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HSCORE");
    }

    public void IncreaseScore()
    {
        score++;
        OnScoreChanged.Invoke(score);
    }

    public void RegisterHighScore()
    {
        if (score > highScore); // we got a new high score 
        {
            highScore = score;
            OnNewHighScore.Invoke(highScore);
            PlayerPrefs.SetInt("HSCORE", highScore);
            Debug.Log("High Score Updated");
        }
        
    }

}
