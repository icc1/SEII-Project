using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Combat
{
    public class Combat : MonoBehaviour
    {
        public enum CombatStates
        {
            START,
            PLAYER,
            ENEMY,
            WIN,
            LOSE
        }

        private CombatStates currentState;

        void Start()
        {
            currentState = CombatStates.START;
        }
        void Update()
        {

        }
    }
}
