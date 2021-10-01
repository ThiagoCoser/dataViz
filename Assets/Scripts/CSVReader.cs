using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CSVReader : MonoBehaviour
{

    public TextAsset textAssetData;

    [System.Serializable]


    public class Item
    {

        public string day;
        public int totalDeaths;
        public int newDeaths;
    }

    [System.Serializable]

    public class itemList
    {
        public Item[] items;

    }

    public itemList myItemList = new itemList();


    void Start()
    {
        ReadCSV();
    }


    void ReadCSV()
    {
        string[] data = textAssetData.text.Split(new string[] { "#", "\n" }, StringSplitOptions.None);

        int tableSize = data.Length / 3 - 1;
        myItemList.items = new Item[tableSize];


        for (int i = 0; i < tableSize; i++)
        {

            myItemList.items[i] = new Item();
            myItemList.items[i].day = data[3 * (i + 1)].ToString();
            myItemList.items[i].totalDeaths = int.Parse(data[3 * (i + 1) + 1]);
            myItemList.items[i].newDeaths = int.Parse(data[3 * (i + 1) + 2]);

        }

    }


}
