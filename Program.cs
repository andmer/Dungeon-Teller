﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DT;

namespace Dungeon_Teller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Options());
            //Application.Run(new ProcessSelector());
            //Application.Run(new DungeonTeller());

        }

    }
}