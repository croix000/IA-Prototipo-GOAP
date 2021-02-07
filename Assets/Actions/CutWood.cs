using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutWood : GAction
{
    public override bool PrePerform()
    {
        if (beliefs.GetIntStateValue("toolBroken") == 0)
        {

            return true;
        }
        else
        {
            return false;
        }
    }

    public override bool PostPerform()
    {

        currentTool.SetActive(false);
        beliefs.ModifyState("toolBroken", 0);
        beliefs.RemoveState("hasTool");
        return true;
    }
}
