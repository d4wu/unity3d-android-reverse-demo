using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class info : MonoBehaviour
{
    public static int hero_power = 0;
    public static int turn = 0;
    public static int monster_power = 0;
    public static int add_power = 0;
    public static int temp_power = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("background/Canvas/text1").GetComponent<Text>().text = "英雄战斗力: " + (info.hero_power+info.temp_power).ToString();
        GameObject.Find("background/Canvas/text2").GetComponent<Text>().text = "当前关数: " + info.turn.ToString();
        GameObject.Find("background/Canvas/text3").GetComponent<Text>().text = "怪物战斗力: " + info.monster_power.ToString();
        GameObject.Find("background/Canvas/text4").GetComponent<Text>().text = "重生增加战斗力: " + info.add_power.ToString();
        //GameObject.Find("background/Canvas/error").GetComponent<Text>().text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("background/Canvas/text1").GetComponent<Text>().text = "英雄战斗力: " + (info.hero_power + info.temp_power).ToString();
        GameObject.Find("background/Canvas/text2").GetComponent<Text>().text = "当前关数: " + info.turn.ToString();
        GameObject.Find("background/Canvas/text3").GetComponent<Text>().text = "怪物战斗力: " + info.monster_power.ToString();
        GameObject.Find("background/Canvas/text4").GetComponent<Text>().text = "重生增加战斗力: " + info.add_power.ToString();
        //GameObject.Find("background/Canvas/error").GetComponent<Text>().text = " ";

    }
}
