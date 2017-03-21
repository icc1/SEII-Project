using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Assets.Scripts;
using Assets.Scripts.Locations;

public class EnemyEncounter {
    System.Random encounterRand = new System.Random();
    public bool enemeyEncountered()
    {
        int encounter = encounterRand.Next(0, 100);
        if (encounter <= 30)
            return true; //returns true 30% of the time
        else
            return false;
    }
    public IEnemyGroup getEnemyGroup(IPlayer playerCharacter)
    {
        return generateEnemyGroup(playerCharacter.CurrentLocation);
    }
    private IEnemyGroup generateEnemyGroup(Location playerLocation)
    {
        if(playerLocation.Equals(new Dungeon1()))
        {
            int numberOfEnemies = encounterRand.Next((Dungeon1) playerLocation.)
        }
    }
}
