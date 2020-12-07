using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager sndMan;

    private AudioSource audioSrc;

    private AudioClip[] laserSounds;

    private AudioClip[] playerExplosionSounds;

    private AudioClip[] asteroidExplosionSounds;

    private AudioClip[] gameoverSounds;

    private AudioClip[] uiButtonSounds;

    private int randomLaserSound;

    private int randomDeathSound;

    private int randomAsteroidSound;

    private int randomGameOver;

    private int randomButtonSound;
    // Start is called before the first frame update
    void Start()
    {
        sndMan = this;
        audioSrc = GetComponent<AudioSource>();
        laserSounds = Resources.LoadAll<AudioClip>("LaserSounds");
        playerExplosionSounds = Resources.LoadAll<AudioClip>("PlayerDeathSounds");
        asteroidExplosionSounds = Resources.LoadAll<AudioClip>("AsteroidSounds");
        gameoverSounds = Resources.LoadAll<AudioClip>("GameOverSounds");
        uiButtonSounds = Resources.LoadAll<AudioClip>("ButtonSounds");

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

    public void PlayAsteroidSound()
    {
        randomAsteroidSound = Random.Range(0, 3);
        audioSrc.PlayOneShot(asteroidExplosionSounds[randomAsteroidSound]);
    }

    public void PlayGameoverSound()
    {
        randomGameOver = Random.Range(0, 1);
        audioSrc.PlayOneShot(gameoverSounds[randomGameOver]);
    }

    public void PlayButtonSound()
    {
        randomButtonSound = Random.Range(0, 3);
        audioSrc.PlayOneShot(uiButtonSounds[randomButtonSound]);
    }
}
