using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlienGameSample;

namespace AlienGame
{
    class MainMenuScreen : MenuScreen
    {
        public MainMenuScreen()
            : base("Main")
        {
            // Create our menu entries
            MenuEntry startGameMenuEntry = new MenuEntry("Start Game");
            MenuEntry exitMenuEntry = new MenuEntry("Quit");
            // Hook up menu event handlers
            startGameMenuEntry.Selected += new EventHandler<EventArgs>(startGameMenuEntry_Selected);
            exitMenuEntry.Selected += OnCancel;
            // Add entries to the menu
            MenuEntries.Add(startGameMenuEntry);
            MenuEntries.Add(exitMenuEntry);
        }

        void startGameMenuEntry_Selected(object sender, EventArgs e)
        {
            ScreenManager.AddScreen(new GameplayScreen());
        }

        protected override void OnCancel()
        {
            ScreenManager.Game.Exit();
        }
    }
}
