using Assets.Scripts.GameClasses;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisGrid : MonoBehaviour
{

    public GameObject GreenBlock;
    public GameObject RedBlock;
    public GameObject BlueBlock;
    public GameObject YellowBlock;
    public GameObject PurpleBlock;
    public GameObject WhiteBlock;
    public GameObject OrangeBlock;

    private int gridWidth = 10;
    private int gridHeight = 20;

    private TetrisGameGrid myGrid;

	// Use this for initialization
	void Start ()
    {
        myGrid = new TetrisGameGrid(gridWidth, gridHeight);

        myGrid.gridSpaces[0, 0] = new Block(0, 0, BlockColor.Green);
        myGrid.gridSpaces[1, 0] = new Block(1, 0, BlockColor.Red);
        myGrid.gridSpaces[2, 0] = new Block(2, 0, BlockColor.White);
        myGrid.gridSpaces[3, 0] = new Block(3, 0, BlockColor.Orange);
        myGrid.gridSpaces[4, 0] = new Block(4, 0, BlockColor.Yellow);
        myGrid.gridSpaces[5, 0] = new Block(5, 0, BlockColor.Blue);
        myGrid.gridSpaces[6, 0] = new Block(6, 0, BlockColor.Purple);

        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                if (myGrid.gridSpaces[x, y] != null)
                {
                    if (myGrid.gridSpaces[x,y].color == BlockColor.Green)
                    {
                        GameObject newGreenBlock = GameObject.Instantiate(GreenBlock);
                        newGreenBlock.transform.position = new Vector3(x+0.5f, y+0.5f, 0);
                    }
                    if (myGrid.gridSpaces[x, y].color == BlockColor.Red)
                    {
                        GameObject newRedBlock = GameObject.Instantiate(RedBlock);
                        newRedBlock.transform.position = new Vector3(x + 0.5f, y + 0.5f, 0);
                    }
                    if (myGrid.gridSpaces[x, y].color == BlockColor.Blue)
                    {
                        GameObject newBlueBlock = GameObject.Instantiate(BlueBlock);
                        newBlueBlock.transform.position = new Vector3(x + 0.5f, y + 0.5f, 0);
                    }
                    if (myGrid.gridSpaces[x, y].color == BlockColor.Yellow)
                    {
                        GameObject newYellowBlock = GameObject.Instantiate(YellowBlock);
                        newYellowBlock.transform.position = new Vector3(x + 0.5f, y + 0.5f, 0);
                    }
                    if (myGrid.gridSpaces[x, y].color == BlockColor.Purple)
                    {
                        GameObject newPurpleBlock = GameObject.Instantiate(PurpleBlock);
                        newPurpleBlock.transform.position = new Vector3(x + 0.5f, y + 0.5f, 0);
                    }
                    if (myGrid.gridSpaces[x, y].color == BlockColor.White)
                    {
                        GameObject newWhiteBlock = GameObject.Instantiate(WhiteBlock);
                        newWhiteBlock.transform.position = new Vector3(x + 0.5f, y + 0.5f, 0);
                    }
                    if (myGrid.gridSpaces[x, y].color == BlockColor.Orange)
                    {
                        GameObject newOrangeBlock = GameObject.Instantiate(OrangeBlock);
                        newOrangeBlock.transform.position = new Vector3(x + 0.5f, y + 0.5f, 0);
                    }
                }
            }
        }

    }

    // Update is called once per frame
    void Update ()
    {
	}
}
