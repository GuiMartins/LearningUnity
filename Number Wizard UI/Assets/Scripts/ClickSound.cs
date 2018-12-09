using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ClickSound : MonoBehaviour {

    public AudioClip clickSound;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource audioSource { get { return GetComponent<AudioSource>(); } }

	// Use this for initialization
	void Start () {
        gameObject.AddComponent<AudioSource>();
        audioSource.clip = clickSound;
        audioSource.playOnAwake = false;

        button.onClick.AddListener(() => PlaySound());
	}

    void PlaySound()
    {
        audioSource.PlayOneShot(clickSound);
    }
}
