﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Game
{
    public static Game current;

    public static Character player;
	
    public Game()
    {
        player = new Character();

    }
}
