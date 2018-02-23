using UnityEngine;

public class UINetwork : MonoBehaviour {

    GameObject panelKoneksi;

    // Use this for initialization
    void Start () {
        panelKoneksi = GameObject.Find("PanelKoneksi");
        panelKoneksi.transform.localPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update () {
        
    }
}
