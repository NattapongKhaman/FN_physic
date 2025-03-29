using System;
using UnityEngine;
using UnityEngine.UI;

public class EndCR : MonoBehaviour
{
    public Image[] endCR;

    private void Awake()
    {
        endCR[1].enabled = false;
    }
    void Start()
    {
        Invoke("ShowEndCR",2f);
    }

    private void ShowEndCR()
    {
        endCR[0].enabled = false;
        endCR[1].enabled = true;
    }
}
