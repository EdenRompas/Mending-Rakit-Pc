using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    // Start is called before the first frame update
    public float scaleAmount = 2.0f; // Ubah angka ini sesuai keinginan.
    void Start()
    {
        // Mendapatkan komponen Transform dari objek ini.
        Transform objTransform = GetComponent<Transform>();

        // Mengganti skala objek.
        objTransform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
