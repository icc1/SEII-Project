using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Assets.Scripts;
using Assets.Scripts.Combat_Interfaces;
using Assets.Scripts.InfoManagers;

class EnemyEncounter {
    System.Random encounterRand = new System.Random();
    int chanceOfEncounter = 30;

    int dungeon1BaseID = 10;
    int dungeon1EnemyTypes = 2;

    public bool enemeyEncountered()
    {
        int encounter = encounterRand.Next(0, 100);
        if (encounter <= chanceOfEncounter)
            return true;
        else
            return false;
    }
    private IEnemyGroup generateEnemyGroup(Location.Type playerLocation)
    {
        IEnemyGroup newGroup = new EnemyGroup();

        if(playerLocation > Location.Type.TOWN)
        {
            int numberOfEnemies = encounterRand.Next(1, Location.getMaxEnemies(playerLocation));
            for(int i = 0; i < numberOfEnemies; i++)
            {
                newGroup.addEnemy(generateEnemy(playerLocation));
            }
            return newGroup;
        }
        else
        {
            return null;
        }
    }
    private IEnemyNPC generateEnemy(Location.Type playerLocation)
    {
        int enemySelector; 
        if (playerLocation == Location.Type.DUNGEON1)
        {
            enemySelector = encounterRand.Next(dungeon1BaseID, dungeon1EnemyTypes - 1);
            return EnemyInfo.findEnemy(enemySelector);
        }
        else
        {
            return null;
        }
    }

}
