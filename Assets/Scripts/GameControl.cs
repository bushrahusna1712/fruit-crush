using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField] Text scoreText;

    [SerializeField] int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        SetText();
    }

    void SetText()
    {
        scoreText.text = score.ToString();
    }

    public void AddPoints(int points)
    {
        score += points;
        SetText();
    }

    public void GameOver()
    {
        PlayerPrefs.SetInt("userScore", score);
        SceneManager.LoadScene("Lose Scene");
    }
}
