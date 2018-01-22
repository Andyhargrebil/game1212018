using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts.GameClasses
{
    public class TetrisGameGrid : MonoBehaviour
    {
        public Block[,] gridSpaces;

        public int width;
        public int height;

        // Use this for initialization
        public void Initialize()
        {
            gridSpaces = new Block[width, height];
        }

        public TetrisGameGrid(int desiredWidth, int desiredHeight)
        {
            this.width = desiredWidth;
            this.height = desiredHeight;

            Initialize();
        }
    }
}
