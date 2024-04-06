using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    [SerializeField] private GameObject OneByOne;
    [SerializeField] private GameObject OneByOneFlat;
    [SerializeField] private GameObject emptyObj;
    GameObject parentObj;
    List<Brick> bricks = new List<Brick>();
    // Start is called before the first frame update
    private void Start()
    {
        Brick SquareBrick = new Brick(20, 20, true, Color.red, "SquareBrick");
        InstantiateBrick(SquareBrick, new Vector3(0,0,0), new Quaternion(0,0,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateBrick(int width, int length, bool flat, Color color, string name)
    {
        bricks.Add(new Brick(width, length, flat, color, name)); 
    }
    private void InstantiateBrick(Brick brick, Vector3 position, Quaternion rotation)
    {
        GameObject parentObj = Instantiate(emptyObj, position, rotation);
        for (int i = 0; i < brick.Width; i++)
        {
            for (int j = 0; j < brick.Length; j++)
            {
                GameObject brickType = brick.Flat ? OneByOneFlat : OneByOne;
                brick.Singles[i + j].SingleObj = 
                Instantiate(brickType, new Vector3(i*0.79f, position.y, j*0.79f), 
                new Quaternion(0, 0, 0, 0), parentObj.transform);
                foreach(Renderer r in brick.Singles[i+j].SingleObj.GetComponentsInChildren<Renderer>()){
                    r.material.color=Color.red;
                }
            }
        }
    }
}
