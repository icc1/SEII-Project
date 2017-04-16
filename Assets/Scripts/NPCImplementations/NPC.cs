using Assets.Scripts.Combat_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.Combat;
using Assets.Scripts.NPCInterfaces;


public class Npc : Stats, INpc
{
    private String npcName;
    private String npcSprite;
    private Location.Type npcSpawnLocation;
    private int defaultSpriteNumber;


    public Npc(String NPCName, String NPCSprite, int spriteNumber, Location.Type NPCSpawnLocation,
        int NPCAttack, int NPCHealth, int NPCDefense, int NPCSpeed)
    {
        this.NPCName = NPCName;
        this.NPCSprite = NPCSprite;
        this.NPCSpawnLocation = NPCSpawnLocation;
        this.DefaultSpriteNumber = spriteNumber;
        this.setStats(NPCAttack, NPCHealth, NPCDefense, NPCSpeed);
    }
    public String NPCName
    {
        get
        {
            return npcName;
        }

        set
        {
            npcName = value;
        }
    }
    public Location.Type NPCSpawnLocation
    {
        get
        {
            return npcSpawnLocation;
        }

        set
        {
            npcSpawnLocation = value;
        }
    }
    public String NPCSprite
    {
        get
        {
            return npcSprite;
        }

        set
        {
            npcSprite = value;
        }
    }
    public int DefaultSpriteNumber
    {
        get
        {
            return defaultSpriteNumber;

        }
        set
        {
            defaultSpriteNumber = value;
        }
    }
}
