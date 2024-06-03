using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{

    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem dieEffect;
  private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag=="Ground"){
        dieEffect.Play();
        Invoke("reloadScene", loadDelay);
    }
  }

  void reloadScene(){
        SceneManager.LoadScene(0);
  }


}
