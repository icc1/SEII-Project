using UnityEngine;
using System.Collections;


//Class for handling Coins
//Will need to access and manipulate an int in the player class
//Will be involved with several areas such as buying, selling, and rewards
public class MoneySystem : MonoBehaviour
{
    //Number of coins held by the player. Will need to be saved
    static int coins;
    static int maxCoins = 99;


    //Load the saved money on startup
    void Start()
    {
        //Needs implementation
    }


    //Save the money, called by SaveGame
    void SaveCoins()
    {
        //Needs writing
    }


    //Buying function
    public static bool BuyItem(int cost)
    {
        //If the palyer has enough to buy, return true and subtract from players coins
        if (coins - cost >= 0)
        {
            coins -= cost;
            return true;
        }

        //Return false if the player doesn't have enough coins.
        //Needs to produce an error messege to the player
        else
        {
            return false;
        }
    }


    //Increase the amount of the players money.
    //Can be done by selling items, or drops for beating monsters
    //Capped at 99
    public static void AddMoney(int amount)
    {
        if (coins + amount > maxCoins)
            coins = maxCoins;
        else
            coins += amount;
    }
}