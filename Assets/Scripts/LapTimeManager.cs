using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {
    public int minuteCount;
    public int secondCount;
    public float milliCount;
    public static string milliDisplay;

    public int totalScore;

    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject milliBox;

    void Update() {
        milliCount += Time.deltaTime * 10;
        milliDisplay = milliCount.ToString("F0");
        milliBox.GetComponent<Text>().text = "" + milliDisplay;

        if (milliCount >= 10) {
            milliCount = 0;
            secondCount++;
        }

        if (secondCount <= 9) {
            secondBox.GetComponent<Text>().text = "0" + secondCount + ".";
        } else {
            secondBox.GetComponent<Text>().text = "" + secondCount + ".";
        }

        if (secondCount >= 60) {
            secondCount = 0;
            minuteCount++;
        }

        if (minuteCount <= 9) {
            minuteBox.GetComponent<Text>().text = "0" + minuteCount + ":";
        } else {
            minuteBox.GetComponent<Text>().text = "" + minuteCount + ":";
        }

        totalScore = 100000 - (minuteCount * 12000) - (secondCount * 200);
    }
}
