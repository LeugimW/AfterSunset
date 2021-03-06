using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso2 : MonoBehaviour
{

    public GameObject[] tiles;

    public int[,] map = new int[,]
    {
        {13, 07, 07, 07, 07, 07, 15, 07, 07, 00, 00, 15, 07, 07, 07, 07, 07, 07, 07, 15 },
        {04, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {14, 10, 10, 10, 10, 00, 16, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 01, 07, 07, 00, 07, 15, 07, 07, 15 },
        {04, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 01, 00, 00, 01 },
        {04, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 01, 07, 07, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 01, 00, 00, 01 },
        {04, 00, 00, 14, 10, 10, 10, 00, 10, 10, 00, 16, 10, 00, 10, 10, 16, 10, 10, 16 },
        {04, 00, 00, 00, 00, 00, 00, 00, 01, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 00, 00, 00, 00, 00, 01, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 00, 00, 00, 00, 00, 01, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {04, 00, 00, 00, 00, 00, 00, 00, 01, 00, 00, 01, 00, 00, 00, 00, 00, 00, 00, 01 },
        {14, 10, 10, 10, 10, 10, 10, 10, 16, 10, 10, 16, 10, 10, 10, 10, 10, 10, 10, 16 },

    };
    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateMap()
    {
        for (int row = 0; row < 20; row++)
        {
            for (int col = 0; col < 20; col++)
            {
                int tileIndex = map[row, col];
                GameObject newTile = Instantiate(tiles[tileIndex], transform);

                newTile.transform.position = new Vector3(col * 3f, 0, row * -3f);
            }
        }
    }
}
