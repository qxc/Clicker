using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Resources : MonoBehaviour {

    public Text textGold;
    public Text textTime;

    public Resources()
    {

    }

    public void updateResources(int gold, int time)
    {
        textGold.text = "Gold: " + gold.ToString();
        textTime.text = "Time: " + time.ToString();
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

