using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] myItems;

    [SerializeField] int[] itemCounts;

    // Start is called before the first frame update
    void Start()
    {
        for (int itemNo = 0; itemNo < myItems.Length; itemNo++)
        {
            for (int count = 0; count < itemCounts[itemNo]; count++)
            {
                GameObject.Instantiate(myItems[itemNo]);
            }
        }
    }
}
