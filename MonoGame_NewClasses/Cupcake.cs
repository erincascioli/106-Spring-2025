using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace MonoGame_NewClasses
{
    public class Cupcake
    {
        // Fields
        //private Vector2 position;
        private Texture2D imageToDisplay;
        private Rectangle rect;
        private Vector2 position;

        // Persist? 
        //private KeyboardState kbState;

        private float angleOfRotation;

        public Cupcake(int xPosition, int yPosition, int width, int height, 
            Texture2D image)
        {
            this.imageToDisplay = image;
            this.rect = new Rectangle(xPosition, yPosition, width, height);
            angleOfRotation = 0f;
            this.position = new Vector2(xPosition, yPosition);

            //System.Diagnostics.Debug.WriteLine(imageToDisplay.Width);
        }

        public void Update()
        {
            // When the user presses the R key (r for rotation)
            //   Image rotates by X degrees
            KeyboardState kbState = Keyboard.GetState();
            if(kbState.IsKeyDown(Keys.R))
            {
                angleOfRotation += 1f;
                //Debug.WriteLine(angleOfRotation);
            }
        }

        public void Draw(SpriteBatch _sb)
        {
            /*
            _sb.Draw(
                imageToDisplay,
                position,
                null,
                Color.White,
                angleOfRotation,
                new Vector2(imageToDisplay.Width/2, imageToDisplay.Height/2),
                0f,
                SpriteEffects.None,
                1f);
            */
            _sb.Draw(
                imageToDisplay,
                rect,
                Color.White);
            Debug.WriteLine("In draw");
        }
    }
}
