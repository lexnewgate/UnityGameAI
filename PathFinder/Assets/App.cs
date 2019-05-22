using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class App : MonoBehaviour
{
    public int CellsUp;
    public int CellsAcross;
    public GameObject ground;
    public GameObject cell;
    private GameObject[,] blocks;

    async void Start()
    {
        blocks=new GameObject[CellsAcross,CellsUp];

        for (int j = 0; j < CellsAcross; j++)
        {
            for (int i = 0; i < CellsUp; i++)
            {
                var block = Object.Instantiate<GameObject>(cell);
                block.transform.position = new Vector3(i, 0, j);
                block.transform.SetParent(ground.transform, true);
                block.name = $"{j} {i}";
                blocks[j, i] = block;
                await new WaitForSeconds(0.2f);
            }
        }

    }

    void OnDrawGizmos()
    {
        if (blocks == null)
        {
            return ;
        }
        for (int i = 0; i < CellsUp; i++)
        {
            for (int j = 0; j < CellsAcross; j++)
            {
                Gizmos.color = Color.green;
                if (blocks[j, i] != null)
                {
                    Gizmos.DrawSphere(blocks[j,i].transform.position,0.2f);
                }
            }
        }
    }

    void Update()
    {
        
    }
}
