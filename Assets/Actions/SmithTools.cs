using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmithTools : GAction
{
    public override bool PrePerform()
    {
        if (GWorld.Instance.GetWorld().GetIntStateValue("ore") >= 3 && GWorld.Instance.GetWorld().GetIntStateValue("wood") >= 3)
            return true;
        else
            return false;
    }

    public override bool PostPerform()
    {

        GWorld.Instance.GetWorld().ModifyState("ore", -3);
        GWorld.Instance.GetWorld().ModifyState("wood", -3);
        return true;
    }
}
