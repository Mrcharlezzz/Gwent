using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCard : Card
    {

        public int baseatk {get;set;} //atk stands for attack
        public int atk {get; set;}
        public string effectdescription {get; set;} 
        public Position position{get;set;}

        public enum Position
        {
            M,R,S,MR,MS,RS,MRS //Rows where the unit can be played M(Melee) R(Range) S(Siege)
        }
        //Initialize
        public UnitCard(string name,Sprite image,Card.Type type, string carddescription,Card.Faction faction,int baseatk,int atk,string effectdescription,UnitCard.Position position)
        {
            Name=name;
            this.image=image;
            this.type=type;
            this.carddescription=carddescription;
            this.faction=faction;
            this.baseatk=baseatk;
            this.atk=atk;
            this.effectdescription=effectdescription;
            this.position=position;
        }
    }