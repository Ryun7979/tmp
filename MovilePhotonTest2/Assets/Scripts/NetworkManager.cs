using System.Collections;
using System.Collections.Generic;
using Photon;
using UnityEngine;

public class NetworkManager : Photon.MonoBehaviour {

	// Use this for initialization
	void Start () {
        //ログをすべて表示する
        PhotonNetwork.logLevel = PhotonLogLevel.Full;

        //ロビーに自動で入る
//        PhotonNetwork.autoJoinLobby = true;

        //ゲームのバージョン設定
        PhotonNetwork.ConnectUsingSettings("v0.2");
    }
    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }

    //ロビーに入ると呼ばれる
    void OnJoinedLobby()
    {
        Debug.Log("ロビーイン");

        //ルームに入る
        PhotonNetwork.JoinRandomRoom();
    }

    //ルームに入ると呼ばれる
    void OnJoinedRoom()
    {
        Debug.Log("ルームイン");
    }

    //ルームインが失敗したら
    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("ルームイン失敗した");

        //ルームが無いと失敗するので、自分で作る
        //引数でルーム名を指定
        PhotonNetwork.CreateRoom(null);
    }

	
}
