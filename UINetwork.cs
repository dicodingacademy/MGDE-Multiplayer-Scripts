using UnityEngine;
using UnityEngine.UI;

public class UINetwork : MonoBehaviour {

    GameObject panelKoneksi;

    Button btnHost;
    Button btnJoin;
    Button btnCancel;
    Text txInfo;

    // Use this for initialization
    void Start () {
        panelKoneksi = GameObject.Find("PanelKoneksi");
        panelKoneksi.transform.localPosition = Vector3.zero;

        btnHost = GameObject.Find("BtnHost").GetComponent<Button>();
        btnJoin = GameObject.Find("BtnJoin").GetComponent<Button>();
        btnCancel = GameObject.Find("BtnCancel").GetComponent<Button>();
        txInfo = GameObject.Find("Info").GetComponent<Text>();

        btnHost.onClick.AddListener(StartHostGame);
        btnJoin.onClick.AddListener(StartJoinGame);
        btnCancel.onClick.AddListener(CancelConnection);
        btnCancel.interactable = false;
    }

    // Update is called once per frame
    void Update () {
        
    }

    private void StartHostGame()
    {
        Debug.Log("ketika tombol Host ditekan");
    }

    private void StartJoinGame()
    {
        Debug.Log("ketika tombol Join ditekan");
    }

    private void CancelConnection()
    {
        Debug.Log("ketika tombol Cancel ditekan");
    }

}
