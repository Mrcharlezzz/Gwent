using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;




public class Card: MonoBehaviour
{
        public string Name;
        public Sprite image;
        public Type type;
        public string carddescription;
        public Faction faction;
 
        public enum Type
    {
        Leader,
        Golden,
        Silver,
        Weather,
        Boost,
        Decoy,
        Clean,
    }
    public enum Faction
    {
        Rome,
        Greece,
        Egypt,
        Neutral,
    }
}



    
 


