using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //�z��̐錾------
    int[] map;  //int�z��̃N���X----

    // Start is called before the first frame update--
    void Start()
    {
        //�z��̍쐬�Ə�����------
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };

        string debugText = "";   //������̐錾�Ə�����
        for(int i=0; i<map.Length; i++)
        {
            //�v�f�����ЂƂ��o��-----
            // Debug.Log(map[i] + ",");

            //������Ɍ������Ă���
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

        //���ړ�---------------------------------
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
