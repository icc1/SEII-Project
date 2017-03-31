using UnityEngine;
using System.Collections;


//Class for handling Coins
//Will need to access and manipulate an int in the player class
//Will be involved with several areas such as buying, selling, and rewards
public class MoneySystem : MonoBehaviour
{
    //Local int variable to be manipulated and returned.
    int coins;

    //Gets the current coins from the player
    public static int GetPlayerCoins()
    {
        //Method needed
        return PlayerCoins; //playercoins
    }

    //Method to set player coins
    //Needs to be done once the player class has the int variable
    public void SetPlayerCoins(int coins)
    {
        player.coins = coins;
    }

    //Buying function
    public static bool BuyItem(int cost)
    {
        coins = GetPlayerCoins();

        //If the palyer has enough to buy, return true and subtract from players coins
        if (coins - cost >= 0)
        {
            coins -= cost;
            SetPlayerCoins(coins);
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
        coins = GetPlayerCoins();

        coins += amount;

        if (coins > 99)
            coins = 99;

        SetPlayerCoins(coins);
    }
}