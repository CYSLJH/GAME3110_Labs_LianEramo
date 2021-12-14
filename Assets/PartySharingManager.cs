using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PartySharingManager : MonoBehaviour
{
    public GameObject sharePartyButton, sharingRoomNameInputField, joinSharingRoomButton;

    NetworkedClient networkedClient;

    // Start is called before the first frame update
    void Start()
    {
        sharePartyButton.GetComponent<Button>().onClick.AddListener(SharePartyButtonPressed);
        joinSharingRoomButton.GetComponent<Button>().onClick.AddListener(JoinSharingRoomButtonPressed);

        networkedClient = GetComponent<NetworkedClient>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JoinSharingRoomButtonPressed()
    {
        string name = sharingRoomNameInputField.GetComponent<InputField>().text;
        networkedClient.SendMessageToHost(ClientToServerSignifiers.JoinSharingRoom + "," + name);
    }

    public void SharePartyButtonPressed()
    {
        AssignmentPart2.SendPartyDataToServer(networkedClient);
    }
}
