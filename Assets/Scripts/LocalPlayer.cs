using Assets.Scripts.SERVER;

using hololensMulti;

using hololensMultiplayer;
using hololensMultiplayer.Models;

using Lidgren.Network;

using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Zenject;

public class LocalPlayer : MonoBehaviour
{
    public Transform qrPos;

    [Inject]
    private DataManager dataManager;

    [Inject]
    private NetClient netclientclient;

    private Client client;

    public bool HaveRH, HaveLH = false;
    public Transform RH, LH;

    public void SetRightHand(bool state)
    {
        HaveRH = state;
    }

    public void SetLeftHand(bool state)
    {
        HaveLH = state;
    }


    void Start()
    {
        dataManager.LocalPlayer = new PlayerData();
        dataManager.LocalPlayer.playerObject = gameObject;

        client = FindObjectOfType<Client>(true);
    }


    void Update()
    {
        if (netclientclient.ConnectionStatus == NetConnectionStatus.Connected && dataManager.LocalPlayer != null && dataManager.LocalPlayer.playerObject.activeSelf)
        {
            PlayerTransform playerTransform = new PlayerTransform();
            playerTransform.SenderID = dataManager.LocalPlayer.ID;

            Vector3 qrRelativePos = transform.localPosition - qrPos.localPosition;
            playerTransform.Pos = qrRelativePos;
            playerTransform.Rot = transform.localRotation;
            
            if (RH != null)
            {
                playerTransform.RHPos = RH.position - transform.position;
                playerTransform.RHRot = RH.localRotation;
            }
            else
            {
                RH = transform.parent.Find("Right_HandSkeleton(Clone)")?.Find("Palm Proxy Transform");
            }

            if (LH != null)
            {
                playerTransform.LHPos = LH.position - transform.position;
                playerTransform.LHRot = LH.localRotation;
            }
            else
            {
                LH = transform.parent.Find("Left_HandSkeleton(Clone)")?.Find("Palm Proxy Transform");
            }

            client.MessageProcessors[MessageTypes.PlayerTransform].AddOutMessage(playerTransform);
        }
    }
}
