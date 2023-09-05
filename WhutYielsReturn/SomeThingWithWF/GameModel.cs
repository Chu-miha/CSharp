using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeThingWithWF
{
    public class GameModel
    {
        public readonly int Size;
        bool[,] game;
        public GameModel(int size)
        {
            Size = size;
            game = new bool[size, size];
        }

        public bool this[int row, int column]
        {
            get { return game[row, column]; }
        }

        public event Action<int, int, bool> StateChanged;

        
        void SetState(int row, int column, bool value)
        {
            game[row, column] = value;
            if (StateChanged != null)
            {
                StateChanged(row, column, value );

            }
        }

        public void Start()
        {
            for (int row = 0; row < Size; row++)
            {
                for(int column = 0; column < Size; column++)
                {
                    SetState(row, column, (row + column) % 2 == 0);
                }
            }
        }

        void Flip(int row, int column)
        {
            SetState(row, column, !game[row, column]);
        }

        public void MakeMove(int row, int column)
        {
            for (int iRow = 0; iRow < Size; iRow++)
            {
                if (iRow != row)
                {
                    Flip(iRow, column);
                }
            }
            for (int iColumn = 0; iColumn < Size; iColumn++)
            {
                if (iColumn != column)
                {
                    Flip(row, iColumn);
                }
            }
        }
    }
}
