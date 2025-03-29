using System;
using UnityEngine;
using UnityEngine.UI;

public class HP_UI : MonoBehaviour
{
    private int currentHp;
    private int currentMap;
    
    public Image[] Hp;
    public Image[] Level;
    public  PlayerCon player;

    private void Awake()
    {
        currentHp = player.maxHp;

    }
    private void Update()
    {
        currentHp = player.currentHp;        
        currentMap = player.currentMap;
       
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
        
        for (int a = 0; a < Level.Length; a++)
        {
            if (a < currentMap)
            {
                Level[a].enabled = true;
            }
            else
            {
                Level[a].enabled = false;
            }
        }

    }
}
