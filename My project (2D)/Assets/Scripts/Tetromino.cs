using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetromino
{
<<<<<<< HEAD
    I,
    O,
    T,
    J,
    L,
    S,
    Z
=======
    I, J, L, O, S, T, Z
>>>>>>> 8f322c2fe595150e8058a309da2f0dbf76e48ffa
}

[System.Serializable]
public struct TetrominoData
{
<<<<<<< HEAD
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
=======
    public Tile tile;
    public Tetromino tetromino;
    public Vector2Int[] cells { get; private set; }
    public Vector2Int[,] wallKicks { get; private set; }

    public void Initialize()
    {
        cells = Data.Cells[tetromino];
        wallKicks = Data.WallKicks[tetromino];
>>>>>>> 8f322c2fe595150e8058a309da2f0dbf76e48ffa
    }
}