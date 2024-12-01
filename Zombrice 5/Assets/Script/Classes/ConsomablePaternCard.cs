using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;


public class ConsomablePaternCard : Card
{

    public List<Vector2> listRedDamagePosition;
    public List<Vector2> listOrangeDamagePosition;
    public List<Vector2> listYellowDamagePosition;

    public ConsomablePaternCard(int _id, List<Vector2> _listRedDamagePosition, List<Vector2> _listOrangeDamagePosition, List<Vector2> _listYellowDamagePosition) 
    {
    
        id  = _id;
        listRedDamagePosition = _listRedDamagePosition;
        listOrangeDamagePosition = _listOrangeDamagePosition;
        listYellowDamagePosition = _listYellowDamagePosition;
    
    }

}
