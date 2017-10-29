using UnityEngine;
using System.Collections;

public class Action {

    public int[] cost { get; set; }
    public int[] reward { get; set; }

    public Action(int [] cost_, int [] reward_)
    {
        //cost[0] = one;
        //cost[1] = two;
        cost = cost_;
        reward = reward_;
		Debug.Log ("Instantiating an action!");
    }

    public string toStringCost()
    {
        return "Gold: " + cost[0] + "\nTime: " + cost[1];
    }

    public string toStringReward()
    {
        return "Gold: " + reward[0] + "\nTime: " + reward[1];
    }

}
