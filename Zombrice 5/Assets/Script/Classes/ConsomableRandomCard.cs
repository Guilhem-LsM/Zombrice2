using UnityEngine;
using System.Collections.Generic;
public class ConsomableRandomCard : Card
{

    public int howMuchBomb;
    public Vector2 firstPointZone;
    public Vector2 secondPointZone;

    public ConsomableRandomCard(int _id, int _howMuchBomb, Vector2 _firstPointZone, Vector2 _secondPointZone) 
    {
    
        id = _id;
        howMuchBomb = _howMuchBomb;
        firstPointZone = _firstPointZone;
        secondPointZone = _secondPointZone;

    }

}
