using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //配列の宣言------
    int[] map;  //int配列のクラス----

    // Start is called before the first frame update--

    void PrintfArray()//-------------------------------
    {
        string debugText = "";
        for (int i = 0; i < map.Length; i++)
        {
            debugText += map[i].ToString() + ",";
        }
        Debug.Log(debugText);
    }

    int GetPlayerIndex()//-------------------------------
    {
        for (int i = 0; i < map.Length; i++)
        {
            if (map[i] == 1)
            {
                return i;
            }
        }
        return -1;
    }

    bool MoveNumber(int number, int moveFrom, int moveTo)///-----------------
    {

        if (moveTo < 0 || moveTo >= map.Length) { return false; }

        if (map[moveTo] == 2)
        {
            int velocity = moveTo - moveFrom;
            bool success = MoveNumber(2, moveTo, moveTo + velocity);
            if (!success) { return false; }
        }
        map[moveTo] = number;
        map[moveFrom] = 0;
        return true;
    }
    

    void Start()//--------------------------------------------
    {
        //配列の作成と初期化------
        map = new int[] { 0, 2, 0, 1, 0, 2, 0, 0, 0 };

        string debugText = "";   //文字列の宣言と初期化
        PrintfArray();
    }
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                //int playerIndex = -1;
             int playerIndex = GetPlayerIndex();
            MoveNumber(1, playerIndex, playerIndex + 1);
            PrintfArray();
            }

            //左移動---------------------------------
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                int playerIndex = GetPlayerIndex();

            MoveNumber(1, playerIndex, playerIndex - 1);
            PrintfArray();

            }
        }
    }

