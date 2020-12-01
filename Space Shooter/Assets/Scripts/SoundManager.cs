using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager sndMan;

    private AudioSource audioSrc;

    private AudioClip[] laserSounds;

    private AudioClip[] playerExplosionSounds;

    private int randomLaserSound;

    private int randomDeathSound;
    // Start is called before the first frame update
    void Start()
    {
        sndMan = this;
        audioSrc = GetComponent<AudioSource>();
        laserSounds = Resources.LoadAll<AudioClip>("LaserSounds");
        playerExplosionSounds = Resources.LoadAll<AudioClip>("PlayerDeathSounds");

    }

    public void PlayDeathSound()
    {
        randomDeathSound = Random.Range(0, 2);
        audioSrc.PlayOneShot(playerExplosionSounds[randomDeathSound]);
    }

    public void PlayLaserSound()
    {
        randomLaserSound = Random.Range(0, 4);
        audioSrc.PlayOneShot(laserSounds[randomLaserSound]);
    }
}
