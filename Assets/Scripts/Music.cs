using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
    static Music instance = null;
	// Use this for initialization
	void Start () {
        /*
        GameObject.DontDestroyOnLoad(gameObject);
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;
		*/
	}
}