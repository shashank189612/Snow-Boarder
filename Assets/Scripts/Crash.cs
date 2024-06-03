using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{

    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem dieEffect;
    [SerializeField] AudioClip crashSfx;


    bool hasCrashed = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            dieEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSfx);

            FindObjectOfType<PlayerControls>().DisablePLayerControls();

            Invoke("reloadScene", loadDelay);
        }
    }

    void reloadScene()
    {
        SceneManager.LoadScene(0);
    }


}
