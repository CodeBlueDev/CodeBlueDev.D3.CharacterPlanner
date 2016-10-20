// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   The main entry point for the application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.D3.CharacterPlanner.WinForms
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // TODO: Global exception handlers
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
