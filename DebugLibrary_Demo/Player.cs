using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DebugLibrary_Demo;

/// <summary>
/// Player class, handles input and moves with arrow keys
/// </summary>
public class Player {
    private Vector2 position;
    private Texture2D texture;
    private float speed;
    private Vector2 direction;

    /// <summary>
    /// Get-only property for player hitbox
    /// </summary>
    public Rectangle Hitbox {
        get {
            return new Rectangle(
                (int)position.X,
                (int)position.Y,
                100,
                100
            );
        }
    }

    /// <summary>
    /// Get-only property of player's current position
    /// </summary>
    public Vector2 Position {
        get { return position; }
    }

    /// <summary>
    /// Get-only property of center position of player relative to hitbox
    /// </summary>
    public Vector2 CenterPosition {
        get { return Hitbox.Center.ToVector2(); }
    }

    /// <summary>
    /// Get-only property of player's direction vector
    /// </summary>
    public Vector2 Direction {
        get { return direction; }
    }

    /// <summary>
    /// Creates an instance of a player object
    /// </summary>
    /// <param name="position">Initial position of player</param>
    /// <param name="speed">Speed to move player at</param>
    /// <param name="texture">Texture of player's sprite</param>
    public Player(Vector2 position, float speed, Texture2D texture) {
        this.position = position;
        this.speed = speed;
        this.texture = texture;
    }

    /// <summary>
    /// Updates player position/input (arrow keys)
    /// </summary>
    /// <param name="kb">Current frame's keyboard state</param>
    public void Update(KeyboardState kb) {
        // reset direction each frame
        direction = Vector2.Zero;

        // update direction and position with keyboard input:

        if (kb.IsKeyDown(Keys.Left)) {
            position.X -= speed;
            direction.X = -1;
        }

        if (kb.IsKeyDown(Keys.Right)) {
            position.X += speed;
            direction.X = 1;
        }

        if (kb.IsKeyDown(Keys.Up)) {
            position.Y -= speed;
            direction.Y = -1;
        }

        if (kb.IsKeyDown(Keys.Down)) {
            position.Y += speed;
            direction.Y = 1;
        }

        // make direction's length 1 (normalize) if
        //   it's not a zero vector to avoid NaN values
        if (direction != Vector2.Zero) {
            direction.Normalize();
        }
    }

    /// <summary>
    /// Draws the player sprite to the screen
    /// </summary>
    /// <param name="sb">SpriteBatch to draw with</param>
    public void Draw(SpriteBatch sb) {
        sb.Draw(texture, Hitbox, Color.White);
    }
}
