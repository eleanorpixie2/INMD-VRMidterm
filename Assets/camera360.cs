using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class camera360 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Run1");
            File.WriteAllBytes(@"C:", I360Render.Capture());
        }
    }
}
