using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon;

public class objControl : MonoBehaviour
{
    public GameObject g1;
    public GameObject g2;
     PhotonView view ;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();

        if(view.IsMine)
        {
            g1.SetActive(true);
            g2.SetActive(false);
        }
        else {
            g1.SetActive(false);
            g2.SetActive(true);
        }
        
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
