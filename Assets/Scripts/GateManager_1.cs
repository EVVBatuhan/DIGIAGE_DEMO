using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GateManager_1 : MonoBehaviour
{
    public TextMeshPro gateNo;
    public int randomNumber;
    public bool multiply;

    void Start()
    {
        if (multiply == true)
        {
            randomNumber = Random.Range(2, 4);
            gateNo.text = "X " + randomNumber;
        }
        else
        {
            randomNumber = Random.Range(4, 6);
            gateNo.text = "/ " + randomNumber;
        }
    }
}
