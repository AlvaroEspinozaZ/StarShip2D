using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Colors_SO", menuName = "ScriptableObject/Colors_SO/Colors", order = 2)]
public class Colors_SO : ScriptableObject
{
    [SerializeField] public Color[] colorSO;
}
