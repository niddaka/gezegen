using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject[] gezegenler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KendiEkseni();
        GunesEtrafi();

        
    }
    void KendiEkseni() 
    {
        gezegenler[0].transform.Rotate(0, 0.3f, 0);
        gezegenler[1].transform.Rotate(0, 0.3f, 0); 
        gezegenler[2].transform.Rotate(0, 0.3f, 0); 
        gezegenler[3].transform.Rotate(0, 0.3f, 0);
        gezegenler[4].transform.Rotate(0, 0.3f, 0);
        gezegenler[5].transform.Rotate(0, 0.3f, 0);
        gezegenler[6].transform.Rotate(0, 0.3f, 0); 
        gezegenler[7].transform.Rotate(0, 0.3f, 0); 
        gezegenler[8].transform.Rotate(0, 0.3f, 0);
        

    }
    void GunesEtrafi()
    {
        gezegenler[1].transform.RotateAround(gezegenler[0].transform.position, Vector3.up, 20 * Time.deltaTime);
        gezegenler[2].transform.RotateAround(gezegenler[0].transform.position, Vector3.up, 6 * Time.deltaTime);
        gezegenler[3].transform.RotateAround(gezegenler[0].transform.position, Vector3.up, 9 * Time.deltaTime);
        gezegenler[4].transform.RotateAround(gezegenler[0].transform.position, Vector3.up, 11 * Time.deltaTime);
        gezegenler[5].transform.RotateAround(gezegenler[0].transform.position, Vector3.up, 5 * Time.deltaTime);
        gezegenler[6].transform.RotateAround(gezegenler[0].transform.position, Vector3.up, 15 * Time.deltaTime);
        gezegenler[7].transform.RotateAround(gezegenler[0].transform.position, Vector3.up, 7 * Time.deltaTime);
        gezegenler[8].transform.RotateAround(gezegenler[0].transform.position, Vector3.up, 13 * Time.deltaTime);
    }
}
