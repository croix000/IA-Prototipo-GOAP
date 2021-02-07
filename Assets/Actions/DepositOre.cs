using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositOre : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("ore", 3);
        beliefs.ModifyState("toolBroken", 0);
        return true;
    }
}