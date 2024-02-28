using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
[System.Serializable]



public class Card
{
    public int id;
    public string cardname;
    public Sprite image;
    public Type type;
    public string carddescription;
    public Faction faction;
    public int baseatk; //atk stands for attack
    public int atk; 
    public Position position;

    public enum Position
    {
        L,C,M,R,S,MR,MS,RS,MRS //For units,boosters,weather,decoy: Rows where the unit can be played M(Melee) R(Range) S(Siege) L(Leader) C(Clear)
    }
 
    
    public enum Type
    {
        Leader,
        Golden,
        Silver,
        Weather,
        Boost,
        Decoy,
        Clear,
    }
    public enum Faction
    {
        Rome,
        Greece,
        Egypt,
        Neutral,
    }
   

    public Card(int id,string name,Sprite image,Type type, string carddescription,Faction faction,int baseatk,int atk,Position position)
        {
            this.id = id;
            cardname=name;
            this.image=image;
            this.type=type;
            this.carddescription=carddescription;
            this.faction=faction;
            this.baseatk=baseatk;
            this.atk=atk;
            this.position=position;
        }
}



    
 


