using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;




public class Card
    {
        public string name {get;set;}
        public Sprite image {get;set;}
        public Type type{get;set;}
        public string carddescription {get;set;}
        public Faction faction{get;set;}
 
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

    
 


