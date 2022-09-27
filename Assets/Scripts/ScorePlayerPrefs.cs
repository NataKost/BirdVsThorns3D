using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScorePlayerPrefs : MonoBehaviour
{
    void Update()
    {
        TMP_Text text = GetComponent<TMP_Text>();
        int score = PlayerPrefs.GetInt("Score");
        text.text = score.ToString();
    }
}
