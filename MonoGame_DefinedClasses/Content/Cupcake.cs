using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_DefinedClasses.Content
{
    /// <summary>
    /// Cupcake class
    /// Represents a programmer-defined class within this MonoGame project.
    /// Includes its own Update and Draw methods that are called from the Game1 class.
    /// </summary>
    public class Cupcake
    {
        // ----------------------------------------------------------------------------------------
        // Fields of this class
        // ----------------------------------------------------------------------------------------

        // These 4 fields aren't necessary because all of this information can be retrived
        //   from the Rectangle object!
        //private int xPosition;
        //private int yPosition;
        //private int width;
        //private int height;

        private Rectangle cupcakeRect;
        private Texture2D cupcakeImage;
        private Color cupcakeTint;
        private float angleOfRotation;


        /// <summary>
        /// Returns a reference to the rectangle if the Game1 class needs it!
        /// </summary>
        public Rectangle CupcakeRect 
        {
            get{ return cupcakeRect; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="image"></param>
        /// <param name="tint"></param>
        /// <param name="_sb"></param>
        public Cupcake(int xPosition, int yPosition, int width, int height,
            Texture2D image, Color tint)
        {
            this.cupcakeRect = new Rectangle(
                xPosition, 
                yPosition, 
                width, 
                height);
            this.cupcakeImage = image;
            this.cupcakeTint = tint;
            angleOfRotation = 3.14f;
        }


        /// <summary>
        /// Rotate this object by a small amount when a player is pressing the R key.
        /// </summary>
        public void Update()
        {
            // Get current keyboard input state
            KeyboardState kbState = Keyboard.GetState();

            // When pressing R key
            if (kbState.IsKeyDown(Keys.R))
            {
                // Increase the angle by 1 degree pf clockwise-rotation.
                angleOfRotation += (float)(Math.PI/180f);

                // Don't let it exceed 6.28 radians/360!
                if(angleOfRotation > Math.PI * 2)
                {
                    angleOfRotation = 0f;
                }
            }
        }


        /// <summary>
        /// Draw this object to the game window.
        /// </summary>
        public void Draw(SpriteBatch _sb)
        {
            // Need to calculate the rotation's origin? Can do it locally!
            Vector2 originOfRotation = new Vector2(cupcakeImage.Width/2, cupcakeImage.Height/2);

            _sb.Draw(
                cupcakeImage,           // Which image to display?
                cupcakeRect,            // Where and what size?
                null,                   // Source rect - interested in drawing only part?
                cupcakeTint,            // Color
                angleOfRotation,        // Angle (in radians!)
                originOfRotation,       // Where to rotate from? (local space)
                SpriteEffects.None,     // Flip the image?
                1f);                    // Layer depth (with special Begin calls)
        }

        // Demo notes for Erin:
        // - Auto-properties do's and don't's
        // - Fields based on loaded content vs. not
        // - 2 places to reference SpriteBatch
        // - Rotation every frame (only while keyboard input is active)
    }
}
