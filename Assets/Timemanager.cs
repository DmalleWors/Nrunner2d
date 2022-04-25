using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timemanager : MonoBehaviour
{
    public TextMeshProUGUI Texttime;
    public TextMeshProUGUI TextHighscore;

    private float timeInLevel;
    private bool runTimer = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetFloat("Highscore"));
        string score = "Highscore: "+ PlayerPrefs.GetFloat("Highscore").ToString("F1");
        TextHighscore.text = score;
    }

    // Update is called once per frame
    void Update()
    {
        if (runTimer == true)
        timeInLevel += Time.deltaTime;
        Texttime.text = "Time: " + timeInLevel.ToString("F1");
    }
    public void stopandsave(){
        runTimer = false;
        PlayerPrefs.SetFloat("Highscore", timeInLevel);
    }
}
