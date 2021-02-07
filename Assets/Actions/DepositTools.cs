using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositTools : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("tools", 3);
        return true;
    }
}