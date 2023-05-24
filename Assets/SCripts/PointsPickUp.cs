using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsPickUp : PickUp
{
    public override void Activate()
    {
        gm.playerScore += 100;
    }
}
