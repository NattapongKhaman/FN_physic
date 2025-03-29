using System;
using UnityEngine;
using UnityEngine.UI;

public class HP_UI : MonoBehaviour
{
    private int currentHp;
    public Image[] Hp;
    
    public  PlayerCon playerHp;

    private void Awake()
    {
        currentHp = playerHp.maxHp;
    }
    private void Update()
    {
        currentHp = playerHp.currentHp;
       
        for (int a = 0; a < Hp.Length; a++)
        {
            if (a < currentHp)
            {
                Hp[a].enabled = true;
            }
            else
            {
             Hp[a].enabled = false;   
            }
        }


    }
}
