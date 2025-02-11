using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DebugLibrary_Demo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private KeyboardState kb;
        private KeyboardState kbPrev;

        private Player player;
        private SpriteFont arial25;
        private bool enableDebugDrawing = true;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // load texture and initialize player object
            Texture2D playerSprite = Content.Load<Texture2D>("player");
            Vector2 playerPosition = new(200, 200);
            player = new Player(
                playerPosition,     // player initial position
                4f,                 // player speed
                playerSprite        // player's sprite
            );

            // load font
            arial25 = Content.Load<SpriteFont>("arial25");
        }

        protected override void Update(GameTime gameTime)
        {
            // update keyboard state
            kbPrev = kb;
            kb = Keyboard.GetState();

            // exit game when escape pressed
            if (kb.IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            // toggle debug drawing boolean by pressing space key once
            if (kb.IsKeyDown(Keys.Space) && kbPrev.IsKeyUp(Keys.Space))
            {
                enableDebugDrawing = !enableDebugDrawing;
            }

            // update player (get input and move)
            player.Update(kb);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // ~~~ draw player ~~~
            player.Draw(_spriteBatch);

            // ~~~ draw instruction text ~~
            _spriteBatch.DrawString(
                arial25,
                "Press space to toggle debug info\nand arrow keys to move",
                new Vector2(30, 30),
                Color.Black
            );

            // ~~~ draw debug information ~~~

            // Drawing debugging information based on a boolean variable
            //   makes it easy to toggle on and off, and very useful when
            //   testing and debugging issues in larger-scale games.
            if (enableDebugDrawing)
            {
                // I put debug drawing in a separate method to make it
                //   easier to edit later, and to show that you can make
                //   your own classes with "debug drawing" methods.
                //   That way, you can call them in this conditional to
                //   make everything easily toggleable :]
                //
                // For example:
                //   player.DrawDebugInfo(_spriteBatch);
                //   enemy.DrawDebugInfo(_spriteBatch);
                //   map.DrawDebugInfo(_spriteBatch);
                //   etc.
                //
                // ^^^^ So all of these become toggleable with one easy boolean!

                DrawDebugInfo(_spriteBatch);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Draws all debug information (player hitbox and direction) to screen
        /// </summary>
        /// <param name="sb">SpriteBatch to draw with</param>
        private void DrawDebugInfo(SpriteBatch sb)
        {
            // Drawing a combination of shapes and text is SUPER
            //   SUPER useful when showing information to the screen
            //   so you don't have to dig around the locals window
            //   with breakpoints to find in visual studio if something
            //   is not working the way it's supposed to

            // draw player's location next to player:
            Vector2 coordPos = player.Position + new Vector2(100, 100);
            sb.DrawString(
                arial25,
                $"({player.Position.X}, {player.Position.Y})",
                coordPos,
                Color.Black
            );

            // draw player's hitbox:
            DebugLib.DrawRectOutline(
                sb,
                player.Hitbox,
                5f,
                Color.Red
            );

            // draw player's direction:
            Vector2 directionPos = player.CenterPosition + (player.Direction * 100f);
            DebugLib.DrawLine(
                sb,
                player.CenterPosition,
                directionPos,
                5f,
                Color.LimeGreen
            );

            // draw a debug mode label on bottom right of screen:
            DebugLib.DrawRectFill(sb, new Rectangle(510, 410, 300, 100), Color.DarkMagenta);
            sb.DrawString(
                arial25,
                "DEBUG MODE !!",
                new Vector2(530, 427),
                Color.White
            );
        }
    }
}
