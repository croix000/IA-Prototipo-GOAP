using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCutter : GAgent
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("cutWood", 1, false);
        goals.Add(s1, 2);

        SubGoal s2 = new SubGoal("depositWood", 1, false);
        goals.Add(s2, 5);

        SubGoal s3 = new SubGoal("toolFunctioning", 1, false);
        goals.Add(s3, 3);


        beliefs.ModifyState("hasTool", 0);
    }
}