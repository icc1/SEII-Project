using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemyEncounter {
    bool enemeyEncountered()
    {
        System.Random encounterRand = new System.Random();
        int encounter = encounterRand.Next(0, 100);
        if (encounter <= 30)
            return true; //returns true 30% of the time
        else
            return false;
    }
}
