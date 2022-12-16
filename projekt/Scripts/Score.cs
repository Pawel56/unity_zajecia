using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.SetText(""+score);
    }
}
