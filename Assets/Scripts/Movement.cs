using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D body;

    private StatStorage stats;
    private Boolean isLeft = false;
    private Boolean isRight = false;
    private int curNumJumps = 0;

    public void Initialize(StatStorage stats) {
        this.stats = stats;
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.CompareTag(Tags.GroundTag)) {
            this.curNumJumps = 0;
        }
    }

    public void Jump() {
        var numJumps = this.stats.GetStat(RunStats.NumJumps).GetLevel();
        if(this.curNumJumps < numJumps) {
            this.curNumJumps += 1;

            var jumpStat = this.stats.GetStat(RunStats.JumpHeight);
            var jumpHeight = jumpStat.GetLevel() * 6;
            this.body.velocity = new Vector2(this.body.velocity.x, jumpHeight);
        }
    }

    public void StartLeft() {
        this.isLeft = true;
    }

    public void StopLeft() {
        this.isLeft = false;
        this.StopHorizontalMovement();
    }

    public void StartRight() {
        this.isRight = true;
    }

    public void StopRight() {
        this.isRight = false;
        this.StopHorizontalMovement();
    }

    public void Update() {
        if(this.isLeft) {
            this.MoveHorizontal(-1f);
        }
        else if(this.isRight) {
            this.MoveHorizontal(1f);
        }
    }

    private void MoveHorizontal(float direction) {
        var movementSpeed = this.stats.GetStat(RunStats.MovementSpeed);
        var velocity = movementSpeed.GetLevel() * 5;
        this.body.velocity = new Vector2(direction * velocity, this.body.velocity.y);
    }

    private void StopHorizontalMovement() {
        this.body.velocity = new Vector2(0f, this.body.velocity.y);
    }
}
