using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggarManagement : MonoBehaviour
{

    [SerializeField] bool Charaselect1;
    [SerializeField] bool Charaselect2;
    [SerializeField] bool Charaselect3;
    public static bool Triggar1;
    public static bool Triggar2;
    public static bool Triggar3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Charaselect1)
        {
            Triggar1 = true;
        }

        if (Charaselect2)
        {
            Triggar2 = true;
        }

        if (Charaselect3)
        {
            Triggar3 = true;
        }
    }
}
