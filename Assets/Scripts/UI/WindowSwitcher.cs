using UnityEngine;

public class WindowSwitcher : MonoBehaviour
{
    [Header ("List of windows")]
    [SerializeField] public GameObject[] windows;

    public void ShowWindow(int currentWindowIndex)
    {
        int activeWindowIndex = -1;

        for (int i = 0; i < windows.Length; i++)
        {
            if (windows[i].activeSelf)
            {
                activeWindowIndex = i;
                break;
            }
        }

        windows[activeWindowIndex].SetActive(false);
        windows[currentWindowIndex].SetActive(true);
    }
}