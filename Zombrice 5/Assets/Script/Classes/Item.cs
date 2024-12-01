using UnityEngine;

public class Item : MonoBehaviour
{

    public int type;
    public int valueResource;
    public int valueMoney;

    public Item (int _type, int _valueRessource, int _valueMoney) 
    {
    
        type = _type;
        valueResource = _valueRessource;
        valueMoney = _valueMoney;
    
    }

}
