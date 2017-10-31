using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    int gold = 100;
    int time = 100;
    int Time { get; set; }
    int Gold { get; set; }

    void Start()
    {
        //InvokeRepeating("testUpdate", 0.0f, 1.0f);
        testActions();
    }
		
    public void testActions()
    {
        int[] costs = { 2, 5 };
        int[] rewards = { 4, 7 };
        Action test = new Action(costs, rewards);
        test.activateAction();
    }
    
    void testUpdate()
    {
        time++;   
        gold++;
        Resources testResources = new Resources();
        testResources.updateResources(gold,time);
    }
    
}

