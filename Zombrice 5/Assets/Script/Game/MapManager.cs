using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{

    public List<List<int>> map = new List<List<int>>();
    public List<Vector2> movementVerifyAround = new List<Vector2>();


    void Start()
    {

        movementVerifyAround.Add(new Vector2(1, 0));
        movementVerifyAround.Add(new Vector2(1, -1));
        movementVerifyAround.Add(new Vector2(0, -1));
        movementVerifyAround.Add(new Vector2(-1, -1));
        movementVerifyAround.Add(new Vector2(-1, 0));
        movementVerifyAround.Add(new Vector2(-1, 1));
        movementVerifyAround.Add(new Vector2(0, 1));
        movementVerifyAround.Add(new Vector2(1, 1));


        for (int i = 0; i < 120; i++)
        {

            map.Add(new List<int>());
            for(int ii = 0; ii < 80; ii++) 
            {

                if (i < 111)
                {

                    map[i].Add(0);

                }
                else
                {

                    map[i].Add(1);

                }

            }

        }

        PathFinding();

    }

    public void PathFinding() 
    {

        int x = 0;
        int y = 0;

        int smallestNumber = 999;
        Vector2 positionSmallestNumber = new Vector2();

        for (int i = 111; i > -1; i--)
        {

            for (int ii = 0; ii < 80; ii++)
            {

                if (map[i][ii] == 0) 
                {


                    for(int iii = 0; iii < 8; iii++) 
                    {

                        x = i;
                        y = ii;
                        x += (int)movementVerifyAround[iii].x;
                        y += (int)movementVerifyAround[iii].y;

                        if(x < 80 && x >= 0 && y < 120 && y >= 0) 
                        { 
                        
                            if(map[y][x] != 0 && map[i][ii] < smallestNumber) 
                            {
                            
                                smallestNumber = map[y][x];
                                positionSmallestNumber = new Vector2(x, y);
                            
                            }

                        }

                    }

                    map[i][ii] = smallestNumber++;
                    
                }

            }

        }

        Debug.Log("Done !");
   
    }

}
