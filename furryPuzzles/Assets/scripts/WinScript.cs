using UnityEngine;

public class WinScript : MonoBehaviour
{
    int fullElement;
    public static int myElement;
    public GameObject Puzzle;
    public GameObject winPanel;

    void Start()
    {
        fullElement = Puzzle.transform.childCount;
    }

    void Update()
    {
        if (fullElement == myElement)
        {
            winPanel.SetActive(true);
        }
    }

    public static void AddElement()
    {
        myElement++;
    }
}
