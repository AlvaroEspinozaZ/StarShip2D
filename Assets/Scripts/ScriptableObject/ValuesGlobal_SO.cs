using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ValuesGlobal_SO", menuName = "ScriptableObject/ValuesGlobal_SO/values", order = 3)]
public class ValuesGlobal_SO : ScriptableObject
{
    public float damage;
    public int scoreMax;
    public int coinsMax;
    public float moneyMax;
    public string nameNave=" ";
    public float lifeMax;
  
}
