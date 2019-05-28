using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndRace : MonoBehaviour {
    public GameObject carControl;
    public GameObject lapTimeMgr;
    public GameObject lapCompleteTrigger;
    public GameObject raceEndUI;
    public GameObject inRaceUI;
    public GameObject restartButton;
    public GameObject timeBox;
    public GameObject pointsBox;
    public AudioSource LevelMusic;

    void Update() {
        if (lapCompleteTrigger.GetComponent<LapCompleteTrigger>().lapCount > 3) {
            carControl.GetComponent<SimpleCarController>().frontDriverW.motorTorque = 0;
            carControl.GetComponent<SimpleCarController>().frontPassengerW.motorTorque = 0;
            carControl.GetComponent<SimpleCarController>().enabled = false;
            lapTimeMgr.GetComponent<LapTimeManager>().enabled = false;
            LevelMusic.Stop();
            inRaceUI.SetActive(false);
            restartButton.SetActive(false);
            raceEndUI.SetActive(true);
        }

        if (lapTimeMgr.GetComponent<LapTimeManager>().minuteCount <= 9 && lapTimeMgr.GetComponent<LapTimeManager>().secondCount <= 9) {
            timeBox.GetComponent<Text>().text = "0" + lapTimeMgr.GetComponent<LapTimeManager>().minuteCount +
                                                ":0" + lapTimeMgr.GetComponent<LapTimeManager>().secondCount +
                                                "." + lapTimeMgr.GetComponent<LapTimeManager>().milliCount.ToString("F0");
        } else if (lapTimeMgr.GetComponent<LapTimeManager>().minuteCount <= 9 && lapTimeMgr.GetComponent<LapTimeManager>().secondCount > 9) {
            timeBox.GetComponent<Text>().text = "0" + lapTimeMgr.GetComponent<LapTimeManager>().minuteCount +
                                               ":" + lapTimeMgr.GetComponent<LapTimeManager>().secondCount +
                                               "." + lapTimeMgr.GetComponent<LapTimeManager>().milliCount.ToString("F0");
        } else if (lapTimeMgr.GetComponent<LapTimeManager>().minuteCount > 9 && lapTimeMgr.GetComponent<LapTimeManager>().secondCount <= 9) {
            timeBox.GetComponent<Text>().text = "" + lapTimeMgr.GetComponent<LapTimeManager>().minuteCount +
                                               ":0" + lapTimeMgr.GetComponent<LapTimeManager>().secondCount +
                                               "." + lapTimeMgr.GetComponent<LapTimeManager>().milliCount.ToString("F0");
        } else {
            timeBox.GetComponent<Text>().text = "" + lapTimeMgr.GetComponent<LapTimeManager>().minuteCount +
                                               ":" + lapTimeMgr.GetComponent<LapTimeManager>().secondCount +
                                               "." + lapTimeMgr.GetComponent<LapTimeManager>().milliCount.ToString("F0");
        }
            pointsBox.GetComponent<Text>().text = "" + lapTimeMgr.GetComponent<LapTimeManager>().totalScore;
    }
}
