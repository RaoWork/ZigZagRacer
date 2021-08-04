using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour 
{

	[Header("Audio Source")]
	public AudioSource _AudioSource;
	[Range(0, 1)]
	[SerializeField] float volumeBg;
	[SerializeField] bool loop;
	[SerializeField] AudioClip[] backgroundClip;

	[Header("Audio OneShotSource")]
	public AudioSource _AudioSourceOneshot;
	[Range(0, 1)]
	[SerializeField] float volumeOneshot;
	bool loopOnces = false;

	[SerializeField]
	AudioClip collectClip,gomeOverClip,
		enemyClip, clickClip;



	void Start () 
	{
		BackgroundMusicPlay();
	}

	public void CollectPlay()
	{
		PlayOneShot_clip (collectClip);
	}

	public void GameOverPlay()
	{
		PlayOneShot_clip (gomeOverClip);
	}

	public void BackgroundMusicPlay()
	{
		if (backgroundClip.Length > 0)
		{
			int randSelected = Random.Range(0, (backgroundClip.Length - 1));
			Background_clip(backgroundClip[randSelected]);
		}
	}

	public void EnemyMusicPlay()
	{
		Background_clip (enemyClip);
	}

	public void ClickedPlay()
	{
		PlayOneShot_clip (clickClip);
	}

	void Background_clip(AudioClip clip)
	{
		if (clip == null)
			return;

		_AudioSource.volume = volumeBg;
		_AudioSource.clip = clip;
		_AudioSource.loop = loop;
		_AudioSource.Play ();
	}

	void PlayOneShot_clip(AudioClip clip)
	{
		if (clip == null)
			return;

		_AudioSourceOneshot.loop = loopOnces;
		_AudioSourceOneshot.volume = volumeOneshot;
		_AudioSourceOneshot.PlayOneShot (clip, 1);
		_AudioSourceOneshot.Play ();
	}
}