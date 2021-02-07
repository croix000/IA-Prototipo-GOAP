using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositLogs : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("logs", 1);
        beliefs.ModifyState("toolBroken", 0);
        return true;
    }
}
