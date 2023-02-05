using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon;
using Photon.Realtime;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public static bool temp=false;
    public TMP_InputField createInput;
    public TMP_InputField joinInput;
    public static bool ishost=false;
    
    // static string GAME_VERSION = "0.1.0";
    // void Start()
    // {
    //         PhotonNetwork.ConnectUsingSettings(GAME_VERSION);
    // }
    public void CreateRoom()
    { 
        // PhotonNetwork.AutomaticallySyncScene = true;
        ishost=true;
        PhotonNetwork.CreateRoom(createInput.text);
        

    }

    public void JoinRoom()
    {
      ishost=false;
      PhotonNetwork.JoinRoom(joinInput.text);
    }

    // void Awake()
    // {
    //     // #Critical
    //     // this makes sure we can use PhotonNetwork.LoadLevel() on the master client and all clients in the same room sync their level automatically
    // }

  public override void OnJoinedRoom()
  {
    temp=true;
    PhotonNetwork.LoadLevel("Mall");
  }
}