using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blacksmith : GAgent
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("smithTool", 1, false);
        goals.Add(s1, 1);

        SubGoal s2 = new SubGoal("depositTool", 1, false);
        goals.Add(s2, 3);


    }

}
