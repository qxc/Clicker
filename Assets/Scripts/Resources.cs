using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Resources {

    public Text availableGold;
    public Text availableTime;

    public Resources()
    {
		availableGold = GameObject.Find ("CurrentGold").GetComponent<Text>();
		availableTime = GameObject.Find ("CurrentTime").GetComponent<Text>();

    }

    public void updateResources(int gold, int time)
    {
        availableGold.text = "Gold: " + gold.ToString();
        availableTime.text = "Time: " + time.ToString();
    }
    /*void Update()
    {
        int time = 0;
        int gold = 0;
        time++;
        gold++;
        textGold.text = "wtf"+gold.ToString();
    }*/
}

