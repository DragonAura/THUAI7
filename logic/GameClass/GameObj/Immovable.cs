﻿using Preparation.Utility;

namespace GameClass.GameObj;

public abstract class Immovable(XY initPos, int initRadius, GameObjType initType)
    : GameObj(initPos, initRadius, initType)
{
    public override XY Position => position;
}
