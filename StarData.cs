using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarData : CsvData
{
    public int Hip { get; set; } // HIPÔ
    public float RightAscension { get; set; } // Ôo
    public float Declination { get; set; } // ÔÜ
    public float ApparentMagnitude { get; set; } // 
    public string ColorType; // F
    public bool UseConstellation; // ¯ÀÅgp³êé¯©

    public override void SetData(string[] data)
    {
        Hip = int.Parse(data[0]);
        RightAscension = RightAscensionToDegree(int.Parse(data[1]),
            int.Parse(data[2]), float.Parse(data[3]));
        Declination = DeclinationToDegree(int.Parse(data[4]), int.Parse(data[5]), float.Parse(data[6]));
        ApparentMagnitude = float.Parse(data[7]);
        ColorType = data[13].Substring(0, 1);
    }
}
