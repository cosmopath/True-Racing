using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour {
    public GameObject carControl;
    void Start() {
        carControl.GetComponent<SimpleCarController>().enabled = true;
    }
}
