using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    [SerializeField] GameObject block;
 
    private void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            InvokeRepeating("CreateBlock", 0.0f, 0.35f);
        }
       
    }

    private void CreateBlock()
    {
        Instantiate(block, new Vector3(Random.Range(-20, 20) * 0.5f, 7f,0f), new Quaternion());
    }
}
