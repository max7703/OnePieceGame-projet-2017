﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMarineford : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("CurrentLevel").GetComponent<LastLevel>().levelSelected = 2;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}