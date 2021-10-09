using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Extras.Collections
{
public class ResetScene : MonoBehaviour
{
    [SerializeField] private KeyCode resetKey = KeyCode.R;

    private void Update()
    {
        if (Input.GetKeyDown(resetKey))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
}