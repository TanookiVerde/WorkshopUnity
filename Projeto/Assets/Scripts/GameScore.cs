using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class GameScore : MonoBehaviour
{
    private TMP_Text scoreText;
    private int score;
    private Coroutine scoreLoop;

    private void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreLoop = StartCoroutine(ScoreLoop());
    }
    public int GetScore()
    {
        return score;
    }
    public void StopScoreLoop()
    {
        StopCoroutine(scoreLoop);
    }
    private IEnumerator ScoreLoop()
    {
        score = 0;
        while(true)
        {
            yield return new WaitForSeconds(0.1f);
            score++;
            scoreText.text = "SCORE: " + score;
        }
    }
}
