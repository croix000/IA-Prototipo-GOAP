using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTool : GAction
{

    GameObject resource;
    public override bool PrePerform()
    {
        if (GWorld.Instance.GetWorld().GetIntStateValue("tools") > 0)
        {

            if (beliefs.GetIntStateValue("toolBroken") == 0)
            {

                resource = GWorld.Instance.RemoveTool();
                if (resource != null)
                    inventory.AddItem(resource);
                else
                    return false;
                target = inventory.FindItemWithTag("Tool");
                if (target == null)
                    return false;

                GWorld.Instance.GetWorld().ModifyState("tools", -1);
                return true;
            }
            else
            {
                return false;
            }

        }
        else

            return false;

    }


    public override bool PostPerform()
    {

        currentTool.SetActive(true);
        inventory.RemoveItem(target);
        GWorld.Instance.AddTool(target);
        beliefs.RemoveState("toolBroken");

        beliefs.ModifyState("hasTool", 0);
        return true;
    }
}
