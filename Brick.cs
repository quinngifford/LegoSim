using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Brick
{
    //all measurements are divided by 10 from real world
    private const float stud_radius = 0.48f;
    private const float stud_circumference = 0.29f;
    private const float stud_height = 0.18f;
    private const float brick_height = 0.96f;
    private const float brick_width = 0.79f;

    public class Single
    {
        public GameObject SingleObj;
        public bool studUsed = false;
        public bool holeUsed = false;
    }


    public string Name { get; private set; }
    public float Width { get; private set; }
    public float Length { get; private set; }
    public bool Flat { get; private set; }
    public Color Color { get; private set; }
    public Vector3 Position { get; private set; }
    public Single[] Singles { get; private set; }
    public Quaternion Rotation { get; private set; }

    public Brick(int width, int length, bool flat, Color color, string name)
    {
        Width = width;
        Length = length;
        Flat = flat;
        Color = color;
        Name = name;

        Singles = new Single[width * length];
        int count = 0;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Singles[count] = new Single();
                count++;
            }
        }
    }
    void Update()
    {
        
    }
}
