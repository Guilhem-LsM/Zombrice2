using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Scriptable Objects/Weapon")]
public class Weapon : ScriptableObject
{

    public int type; //1, 2, 3
    public Sprite sprite;
    public string name;

    //1
    public List<Vector2> listRedDamagePosition;
    public List<Vector2> listOrangeDamagePosition;
    public List<Vector2> listYellowDamagePosition;

    //2
    public Vector2 firstZone; 
    public Vector2 secondZone;
    public int howMuchBombs;
    public int BombType;

    //3
    public Vector2 position;
    public int damagePerShot;
    public int rateOfFire;
    public int range;

}
