using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Action {

    public int[] cost { get; set; }
    int currentTime;
    public int[] reward { get; set; }
    public Text costText = GameObject.Find("AvailableAction1Cost").GetComponent<Text>();
    public Text rewardText = GameObject.Find("AvailableAction1Reward").GetComponent<Text>();
    public Text activeCostText = GameObject.Find("ActiveAction1Cost").GetComponent<Text>();
    public Text activeRewardText = GameObject.Find("ActiveAction1Reward").GetComponent<Text>();
    bool active = false;

    public Action(int [] cost_, int [] reward_)
    {
        cost = cost_;
        reward = reward_;
        currentTime = cost[1];
        costText.text = getCostText();
        rewardText.text = getRewardText();

    }

    public string getCostText()
    {
        return "Cost Gold: " + cost[0] + " Time: " + cost[1];
    }

    public string getRewardText()
    {
        return "Reward Gold: " + reward[0] + " Time: " + reward[1];
    }

    //How do I get it to respond to clicks?
    public void onClick()
    {
        if (currentTime == 0)
        {
            active = false;
            currentTime = cost[1];
            //stop repeating
        }        
        else if (!active)
        {
            active = true;
            activateAction();
        }
        
    }
    public void activateAction()
    {
        activeCostText.text = getCostText() + " Time Remaining: " + currentTime;
        activeRewardText.text = getRewardText();
        currentTime--;
        //start repeating
    }
}
