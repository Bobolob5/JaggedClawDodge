using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreDisplay : MonoBehaviour
{
    [SerializeField] private FloatSO score;
    [SerializeField] private FloatSO highScore;
    [SerializeField] private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    private void Start()
    {
        if (score.Value > highScore.Value)
        {
            highScore.Value = score.Value;
        }
    }
    private void FixedUpdate()
    {

        scoreText.text = highScore.Value.ToString();
    }
}
