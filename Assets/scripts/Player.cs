using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float speed = 4f;

	public GameObject GameOverPanel;

	public AudioSource BackgroundAudioSource;

	public Rigidbody2D rb;

	private float movement = 0f;
	public bool isAlive = true;



	void Start()
    {
		if(isAlive = true)
        {
			Time.timeScale = 1;
        }
    }

	// Update is called once per frame
	void Update () {
		movement = Input.GetAxisRaw("Horizontal") * speed;
	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.collider.tag == "Ball")
		{
			isAlive = false;
			Time.timeScale = 0;
			Debug.Log("GAME OVER!");
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			GameOverPanel.SetActive(true);
			BackgroundAudioSource.enabled = false;




		}
	}

	

	public void RestartLevel()
    {
		SceneManager.LoadScene(1);
    }
	public void QuitGame()
	{
		Debug.Log("Ouit !");
		SceneManager.LoadScene(0);
		//Application.Quit();
		
	}

}
