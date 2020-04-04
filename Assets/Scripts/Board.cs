using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject tilePrefab;
    public GameObject[] dots;
    private BackgroundTile[,] allTiles;
    private GameObject[,] allDots;
    // Start is called before the first frame update
    void Start()
    {
        allTiles = new BackgroundTile[width,height];
        SetUp();
    }

    private void SetUp(){
        for(int i = 0; i<width; i++)
        {
            for(int y = 0; y<width; y++)
            {
                Vector2 tempPosition = new Vector2(i,y);
                GameObject BackgroundTile = Instantiate(tilePrefab, tempPosition,Quaternion.identity) as GameObject;
                BackgroundTile.transform.parent = this.transform;
                BackgroundTile.name = "( " + i + ", " + y + " )";
                int dotToUse = Random.Range(0, dots.Length);
                GameObject dot = Instantiate(dots[dotToUse], tempPosition, Quaternion.identity);
                dot.transform.parent = this.transform;
                dot.name = "( " + i + ", " + y + " )";
                allDots[i, j] = dot;

            }
        }
    }
}
