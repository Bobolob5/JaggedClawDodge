using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private FloatSO score;

    // Start is called before the first frame update
    private void Start()
    {
        score.Value = 0;
        InvokeRepeating("ScoreIncrease", 0f, 0.1f);
    }

    // Update is called once per frame
    private void ScoreIncrease()
    {
        score.Value++;
    }


}
