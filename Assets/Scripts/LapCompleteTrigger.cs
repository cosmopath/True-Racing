using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTrigger : MonoBehaviour {
    public int lapCount;
    public bool lapPassed;
    public AudioSource LevelMusic;
    public GameObject lapBox;
    public GameObject lapCompleteTrig;
    public GameObject halfLapTrig;
    public GameObject carControl;
    public GameObject lapTimeMgr;

    void OnTriggerEnter() {
        lapCount += 1;
        lapBox.GetComponent<Text>().text = "" + lapCount;
        lapCompleteTrig.SetActive(false);
        halfLapTrig.SetActive(true);
    }
}