using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Combat.Combat_UI
{
    public class ButtonManager : MonoBehaviour
    {
        Button attackButton;
        Button defendButton;
        Button runButton;
        Button inventoryButton;
        private Combat.PlayerChoice selectedButton;

        void Start()
        {
            attackButton = (Button)GameObject.FindGameObjectWithTag("AttackButton").GetComponent(typeof(Button));
            defendButton = (Button)GameObject.FindGameObjectWithTag("DefendButton").GetComponent(typeof(Button));
            runButton = (Button)GameObject.FindGameObjectWithTag("RunButton").GetComponent(typeof(Button));
            inventoryButton = (Button)GameObject.FindGameObjectWithTag("InventoryButton").GetComponent(typeof(Button));

            selectedButton = Combat.PlayerChoice.NONE;
        }

        public void setInteractable(bool desired)
        {
            if (desired == true)
            {
                attackButton.interactable = true;
                defendButton.interactable = true;
                runButton.interactable = true;
                inventoryButton.interactable = true;
            }
            else
            {
                attackButton.interactable = false;
                defendButton.interactable = false;
                runButton.interactable = false;
                inventoryButton.interactable = false;
            }
        }

        public Combat.PlayerChoice getSelected()
        {
            return selectedButton;
        }

        public void setSelected(int selected)
        {
            selectedButton = (Combat.PlayerChoice)selected;
        }
    }
}
