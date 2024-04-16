using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //配列の宣言------
    int[] map;  //int配列のクラス----

    // Start is called before the first frame update--
    void Start()
    {
        //配列の作成と初期化------
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };

        string debugText = "";   //文字列の宣言と初期化
        for(int i=0; i<map.Length; i++)
        {
            //要素数をひとつずつ出力-----
            // Debug.Log(map[i] + ",");

            //文字列に結合していく
            debugText += map[i].ToString() + ",";
        }
        Debug.Log(debugText);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            int playerIndex = -1;
            for(int i=0; i<map.Length; i++)
            {
                if (map[i] == 1)
                {
                    playerIndex = i;
                    break;
                }
            }
            if (playerIndex < map.Length - 1)
            {
                map[playerIndex + 1] = 1;
                map[playerIndex] = 0;
            }
            string debugText = "";
            for(int i=0; i < map.Length; i++)
            {
                debugText += map[i].ToString() + ",";
            }
            Debug.Log(debugText);
        }

        //左移動---------------------------------
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            int playerIndex = -1;
            for(int i=0; i<map.Length; i++)
            {
                if (map[i] == 1)
                {
                    playerIndex = i;
                    break;
                }
            }

            if (playerIndex > 0)
            {
                map[playerIndex - 1] = 1;
                map[playerIndex] = 0;
            }

            string debugText = "";
            for (int i = 0; i < map.Length; i++)
            {
                debugText += map[i].ToString() + ",";
            }
            Debug.Log(debugText);
        }
    }
}
