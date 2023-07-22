using UnityEngine;
using UnityEngine.UI;

public class WordButtons : MonoBehaviour {

    private Color idle = new Color(141f / 255f, 179f / 255f, 226f / 255f, 1f);
    private Color clicked = new Color(136f / 255f, 158f / 255f, 186 / 255f, 1f);

    private void OnMouseDown()
    {
        gameObject.GetComponent<Text>().color = clicked;
    }

    private void OnMouseUp()
    {
        gameObject.GetComponent<Text>().color = idle;
    }
}
