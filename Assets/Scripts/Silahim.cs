using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silahim : MonoBehaviour
{
    RaycastHit hit;
    public GameObject RayPoint;
    private float AtesEtmeSuresi;
    public float AtesEtmeSikligi;
    public float Menzil;

    public AudioSource AtesSesi;

    public ParticleSystem AtesEfekt;

    public Camera BenimCam;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame

    void Update()
    {
        // Debug.DrawRay(RayPoint.transform.position, RayPoint.transform.forward, Color.green);
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > AtesEtmeSuresi)
        {
            AtesET();
            AtesEtmeSuresi = Time.time + AtesEtmeSikligi;
        }
    }

    private void AtesET()
    {
        if (Physics.Raycast(RayPoint.transform.position,RayPoint.transform.forward, out hit, Mathf.Infinity))
        {
            
            // Debug.DrawRay(RayPoint.transform.position,RayPoint.transform.forward,Color.green);
            // Debug.Log(hit.transform.name);
            AtesSesi.Play();
            AtesEfekt.Play();
            Destroy(hit.transform.gameObject);
        }
    }
}
