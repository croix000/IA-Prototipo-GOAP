using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;

    private static Queue<GameObject> tools;

    static GWorld()
    {
        world = new WorldStates();
        tools = new Queue<GameObject>();

        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Tool");
        foreach (GameObject c in cubes)
            tools.Enqueue(c);
        if (cubes.Length > 0)
            world.ModifyState("tools", cubes.Length);
    }

    private GWorld()
    {

    }

    public static GWorld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }


    public void AddTool(GameObject p)
    {
        tools.Enqueue(p);
    }
    public GameObject RemoveTool()
    {
        if (tools.Count == 0) return null;
        return tools.Dequeue();
    }
}
