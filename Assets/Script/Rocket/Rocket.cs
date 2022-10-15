using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : Singleton<Rocket> 
{
    public int Life { get => life; }
    public float Fuel { get => fuel; }

    public Tip Tip { get; private set; } = null;
    public Body Body { get; private set; } = null;
    public Thruster Thruster { get; private set; } = null;

    [Header("Settings")]
    [SerializeField] float blinkDuration;

    [Header("Decrement Fuel Settings")]
    [SerializeField] private float fuelDecrementSeconds = 1.0f;
    [SerializeField] private float fuelDecrementAmount = 1.0f;

    [Header("References")]
    [SerializeField] private GameObject tipSlot;
    [SerializeField] private GameObject bodySlot;
    [SerializeField] private GameObject thrusterSlot;
    [SerializeField] List<GameObject> Backgrounds;

    [Header("ReadOnly for debug")]
    [SerializeField] private float ySpeed = 0f;
    [SerializeField] private float xSpeed = 0f;
    [SerializeField] private float fuel = 0f;
    [SerializeField] private int life = 0;

    private ParticleSystem particleSys;
    private Rigidbody2D rb;
    private bool launched = false;
    private bool isBlinking = false;

    protected override void Awake() {
        base.Awake();
        rb = GetComponent<Rigidbody2D>();
        particleSys = GetComponent<ParticleSystem>();
        particleSys.Stop();
    }

    public void EquipTip(Tip tip) {
        Tip = tip;
        tipSlot.GetComponent<SpriteRenderer>().sprite = tip.ComponenetSprite;
    }

    public void EquipBody(Body body) {
        Body = body;
        bodySlot.GetComponent<SpriteRenderer>().sprite = body.ComponenetSprite;
    }

    public void EquipThruster(Thruster thruster) {
        Thruster = thruster;
        thrusterSlot.GetComponent<SpriteRenderer>().sprite = thruster.ComponenetSprite;
    }

    public void Launch() {
        life += Tip.Life;

        life += Body.Life;
        fuel += Body.Fuel;

        xSpeed += Thruster.XSpeed;
        ySpeed += Thruster.YSpeed;

        foreach (GameObject g in Backgrounds) g.SetActive(false);

        Debug.Log("life: " + life);
        Debug.Log("fuel: " + fuel);
        Debug.Log("xSpeed: " + xSpeed);
        Debug.Log("ySpeed: " + ySpeed);

        StartCoroutine(LaunchCor());
    }

    private IEnumerator LaunchCor() {
        CamerasManager.Instance.EnableLaunchCamera();
        yield return new WaitForSeconds(1.7f);
        particleSys.Play();
        UIManager.Instance.StartCountDownText(3);
        yield return new WaitForSeconds(3);
        CamerasManager.Instance.EnableGameCamera();
        launched = true;
        StartCoroutine(StartDecrementFuel());
        UIManager.Instance.ShowGameInfoPanel(true);
    }

    public bool ReadyToLaunch() {
        return Tip != null && Body != null && Thruster != null;
    }

    private void Update() {
        if (launched) {

            rb.velocity = Vector2.up * ySpeed;

            HandleSpeed();
            HandleShooting();
            UpdateDistance();
        }
    }

    private void HandleSpeed() {

        Vector2 finalSpeed = Vector2.zero;

        if (InputManager.Instance.IsMovingPlayer) {
            if (InputManager.Instance.MoveDirectionPlayer == Vector2.right && transform.position.x < GameController.Instance.XRightMargin - 0.8f) {
                rb.velocity = new Vector2(xSpeed, ySpeed);
            }
            else if (InputManager.Instance.MoveDirectionPlayer == Vector2.left && transform.position.x > GameController.Instance.XLeftMargin + 0.8f) {
                rb.velocity = new Vector2(-xSpeed, ySpeed);
            }
            else rb.velocity = new Vector2(0, ySpeed);
        }
        else rb.velocity = new Vector2(0,ySpeed);
    }

    private void HandleShooting() {
        if (InputManager.Instance.GetShootingPressed()) {
            Debug.Log("pew");
        }
    }

    private IEnumerator StartDecrementFuel()
    {
        while(fuel > 0)
        {
            yield return new WaitForSeconds(fuelDecrementSeconds);
            fuel -= fuelDecrementAmount;
        }
        GameController.Instance.GameOver();
    }
    private void UpdateDistance() {
        UIManager.Instance.ShowDistance((int)(transform.position.y*10));
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Obstacle" && !isBlinking) {
            life--;
            Destroy(collision.gameObject);
            UIManager.Instance.UpdateLifeContainer(life);
            if (life <= 0) {
                GameController.Instance.GameOver();
            }
            isBlinking = true;
            StartCoroutine(disableBlink());
        }
    }

    private IEnumerator disableBlink() {

        float startTime = Time.time;
        particleSys.Stop();

        while(Time.time - startTime < blinkDuration) {
            Debug.Log("looping");
            EnableSprites(!SpriteRenderersEnabled());

            yield return new WaitForSeconds(0.1f);
        }
        EnableSprites(true);
        particleSys.Play();
        isBlinking = false;
    }

    private void EnableSprites(bool _enable) {
        tipSlot.GetComponent<SpriteRenderer>().enabled = _enable;
        bodySlot.GetComponent<SpriteRenderer>().enabled = _enable;
        thrusterSlot.GetComponent<SpriteRenderer>().enabled = _enable;
    }
    private bool SpriteRenderersEnabled() {
        return tipSlot.GetComponent<SpriteRenderer>().enabled;
    }
}
