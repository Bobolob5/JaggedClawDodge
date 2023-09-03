using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private FloatSO score;
    [SerializeField] private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        scoreText.text = score.Value.ToString();
    }
}
