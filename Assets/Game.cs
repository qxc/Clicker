using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    int gold = 100;
    int time = 100;
    int Time { get; set; }
    int Gold { get; set; }

    void Start()
    {
        int[] costs = { 2, 5 };
        int[] rewards = { 4, 7 };
        Action test = new Action(costs, rewards); // how to instantiate a new action?
        test.toStringCost();
        test.toStringReward();
    }

    // Update is called once per frame

    
    void Update()
    {
        time++;   
        gold++;
        Resources testResources = new Resources();
        testResources.updateResources(gold,time);

    }
}

//  Make the action take over the text of the button
// When the button is pushed, deduct the necessary resources if available
// Create a new text window that updates periodically w/ how long it is
// Have update reduce time remaining on new action pane 1x per second
// Goal: Have a button that you push, creates another text box which shows how long until completion and the resources gained and modifies resources of the player cost/outcome