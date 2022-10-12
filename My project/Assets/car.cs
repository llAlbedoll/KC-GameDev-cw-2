using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    string heroName = "Yato";
    int heroAge = 18;
    int heroHeight = 170;
    string heroSuperPower = "Quake";




    string vililanName = "knight";
    int villainAge = 35;
    int vililanHeight = 196;
    string villainSuperPower = "Dark";




    void Start()
    {
        int ageDifference = villainAge - heroAge;
        print(" Yo my name is " + heroName + "my age is" + heroAge + "hight is" + heroHeight + "my super power is" + heroSuperPower);
        print("hey my name is" + vililanName + "my age is" + villainAge + "hight is" + vililanHeight + "my super power is" + villainSuperPower);
    }

        // Update is called once per frame
    void Update()
    {
        
    }
}
