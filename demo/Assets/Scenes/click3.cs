using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Click()
    {
        info.temp_power = 0;
        info.add_power += info.turn * 2000;
        info.hero_power = 0;
        info.monster_power = 0;
        info.turn = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
