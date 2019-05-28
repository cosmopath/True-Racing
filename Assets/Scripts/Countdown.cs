using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {
    public GameObject countdown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public AudioSource LevelMusic;
    public GameObject lapTimer;
    public GameObject carControls;

    void Start() {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart () {
        yield return new WaitForSeconds(0.5f);
        countdown.GetComponent<Text>().text = "3";
        GetReady.Play();
        countdown.SetActive(true);

        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "2";
        GetReady.Play();
        countdown.SetActive(true);

        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "1";
        GetReady.Play();
        countdown.SetActive(true);

        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        GoAudio.Play();
        LevelMusic.Play();
        lapTimer.SetActive(true);
        carControls.SetActive(true);
    }
}
