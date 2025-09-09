using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static CorrectFinger;
public class ResultScript : MonoBehaviour
{
    public int matchScore=0;
    public int timeScore=0;
    public float BaseScore=100f;
    public int TotalScore=0;
    
    
    public Text MatchScoreText;
    public Text TimeScoreText;
    public Text TotalScoreText;
    public Text RemainingTimeScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        matchScore= GameScore.correctScore*20;
        timeScore = GameScore.GoalTime;
        TotalScore = (int)(GameScore.RemainingTime+BaseScore*(1.3*matchScore*0.01));

    }

    // Update is called once per frame
    void Update()
    {
        MatchScoreText.text = ((int)matchScore).ToString();
        TimeScoreText.text = ((int)timeScore).ToString();
        TotalScoreText.text = ((int)TotalScore).ToString();
        RemainingTimeScoreText.text = ((int)GameScore.RemainingTime).ToString();
    }
}
