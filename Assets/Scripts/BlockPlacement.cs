using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor.SceneManagement;
using Unity.VisualScripting;

public class BlockPlacement : MonoBehaviour
{
    public int numberofblocks = 40;
    public GameObject Grass; // accessing Game objects
    public GameObject Sand;
    public GameObject Water;
    public GameObject Tree;


    public float Width = 5f;
    public float height = 5f;
    public float spacing = 5f;


    // Start is called before the first frame update
    void Start()
    {
        var random = new System.Random();
        var list = new List<GameObject> { Grass, Sand, Water };

        for (int y = 0; y < Width; y++)
        { 
            for (int x = 0; x < height; x++ )
            {
                Vector3 pos = new Vector3(x, 0, y) * spacing;
                int index = random.Next(list.Count);
                Instantiate(list[index], pos, Quaternion.identity); 
            }
        }
    }
}
