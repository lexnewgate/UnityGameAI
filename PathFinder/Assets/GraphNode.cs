using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNode
{
    private const int InvalidIndex = -1;
    public int Index { get; set; }

    public GraphNode()
    {
        Index = InvalidIndex;
    }

    public GraphNode(int index)
    {
        Index = index;
    }

}
