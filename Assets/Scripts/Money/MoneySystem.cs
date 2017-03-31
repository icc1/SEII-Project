using UnityEngine;
using System.Collections;


//Class for handling Coins
//Will need to access and manipulate an int in the player class
//Will be involved with several areas such as buying, selling, and rewards
public class MoneySystem : MonoBehaviour
{
    //Number of coins held by the player. Will need to be saved
    int coins;


    //Load the saved money on startup
    void Start()
    {
        AddMoney(PlayerPrefs.GetInt("MoneySave", 0));
    }


    //Save the money, called by SaveGame
    void SaveCoins()
    {
        AddMoney(PlayerPrefs.SetInt("MoneySave", coins));
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
        if (coins + amount > 99)
            coins = 99;
        else
            coins += amount;
    }
}