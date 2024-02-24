using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostCard : Card
    {
        public enum Position
        {
            M,R,S,MR,MS,RS,MRS //Rows where the boost can be played M(Melee) R(Range) S(Siege)
        }
        public int boost {get; set;}
    }