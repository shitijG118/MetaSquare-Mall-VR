using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject hosts;
    public GameObject locals;
    public GameObject host;
    public GameObject local;

    public void Start()
    {
           if(CreateAndJoinRooms.ishost==true)
           {
               hosts.SetActive(true);
        locals.SetActive(false);
        (host. GetComponent("SUPERCharacterAIO.cs") as MonoBehaviour).enabled=true;
         (local. GetComponent("SUPERCharacterAIO.cs") as MonoBehaviour).enabled=false;
        
        
           }
           else{
            hosts.SetActive(false);
        locals.SetActive(true);
        (host. GetComponent("SUPERCharacterAIO.cs") as MonoBehaviour).enabled=false;
         (local. GetComponent("SUPERCharacterAIO.cs") as MonoBehaviour).enabled=true;
           }
    }
    
 }