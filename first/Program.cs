﻿
namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            NumGame game = new NumGame(5);
            game.StartGame();

            game = new NumGame(100);
            game.StartGame();
        }
    }
}
