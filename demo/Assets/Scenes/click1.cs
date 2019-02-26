using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class click1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Click()
    {
        if((info.hero_power + info.temp_power + info.add_power) >= info.monster_power)
        {
            info.turn = info.turn + 1;
            info.hero_power = info.turn * 100 + info.add_power + info.temp_power;
            info.monster_power = (int)Math.Pow(2, info.turn);
            GameObject.Find("background/Canvas/error").GetComponent<Text>().text = " ";
        }
        else
        {
            GameObject.Find("background/Canvas/error").GetComponent<Text> ().text = "英雄战斗力不足，请修炼或者重生增加战斗力";
        }
        Debug.Log(info.turn);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
