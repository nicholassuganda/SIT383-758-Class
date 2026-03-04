using UnityEngine;
using TMPro;

public class ARCamera : MonoBehaviour
{
    public Material mat;
    private WebCamTexture camTexture;
    public TextMeshProUGUI debugText;

    private void Start()
    {
        debugText.text = "Starting up";
        camTexture = new WebCamTexture();
        mat.mainTexture = camTexture;
        camTexture.Play();
        debugText.text = "Playing";
    }
}
