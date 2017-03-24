using Assets.Scripts.Combat_Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using UnityEngine;

namespace Assets.Scripts.InfoManagers
{
    class EnemyInfo : MonoBehaviour
    {
        private static ArrayList enemyList = new ArrayList();
        private String xmlDocName = "Data/enemies.xml";

        public static IEnemyNPC findEnemy(int spawnRoll)
        {
            foreach (IEnemyNPC enemy in enemyList)
            {
                if (enemy.EnemyID == spawnRoll)
                {
                    return enemy;
                }
            }
            return null;
        }

        private void populateList()
        {
            XmlDocument enemyDoc = new XmlDocument();
            enemyDoc.Load(xmlDocName);

            XmlNodeList enemyID = enemyDoc.GetElementsByTagName("enemyID");
            XmlNodeList enemyName = enemyDoc.GetElementsByTagName("enemyName");
            XmlNodeList enemySprite = enemyDoc.GetElementsByTagName("enemySprite");
            XmlNodeList enemySpawnLocation = enemyDoc.GetElementsByTagName("enemySpawnLocation");
            XmlNodeList enemyAttack = enemyDoc.GetElementsByTagName("enemyAttack");
            XmlNodeList enemyHealth = enemyDoc.GetElementsByTagName("enemyHealth");
            XmlNodeList enemyDefense = enemyDoc.GetElementsByTagName("enemyDefense");
            XmlNodeList enemySpeed = enemyDoc.GetElementsByTagName("enemySpeed");

            for(int i = 0; i < enemyID.Count; i++)
            {
                IEnemyNPC tmpEnemy = new EnemyNPC(int.Parse(enemyID[i].InnerText), enemyName[i].InnerText, 
                    enemySprite[i].InnerText, (Location.Type)int.Parse(enemySpawnLocation[i].InnerText),
                    int.Parse(enemyAttack[i].InnerText), int.Parse(enemyHealth[i].InnerText), 
                    int.Parse(enemyDefense[i].InnerText), int.Parse(enemySpeed[i].InnerText));
                enemyList.Add(tmpEnemy);
            }
        }

        public static IEnemyNPCGroup generateEnemyGroup(Location.Type playerLocation)
        {
            System.Random enemyNoRand = new System.Random();
            IEnemyNPCGroup newGroup = new EnemyNPCGroup();

            if (playerLocation > Location.Type.TOWN)
            {
                int numberOfEnemies = enemyNoRand.Next(1, Location.getMaxEnemies(playerLocation));
                for (int i = 0; i < numberOfEnemies; i++)
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

        private static IEnemyNPC generateEnemy(Location.Type playerLocation)
        {
            System.Random selectorRand = new System.Random();
            int enemySelector;
            int dungeon1BaseID = 10;
            int dungeon1EnemyTypes = 2;

            if (playerLocation == Location.Type.DUNGEON1)
            {
                enemySelector = selectorRand.Next(dungeon1BaseID, dungeon1EnemyTypes - 1);
                return EnemyInfo.findEnemy(enemySelector);
            }
            else
            {
                return null;
            }
        }

        void Start()
        {
            DontDestroyOnLoad(transform.gameObject);
            populateList();
        } 
    }
}
