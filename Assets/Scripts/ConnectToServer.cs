using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime; //
using UnityEngine.UI;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Connexion to Photon Network
    private void Start(){ 
        PhotonNetwork.ConnectUsingSettings();
    }

    // When connected, join the lobby
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    //When the lobby is joined, the loading is complete so we load the next scene in the stack
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}