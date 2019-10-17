/****************************** Ali Nouri ******************************\
*	Module Name:	Program.cs
*	Project:		Localization
*	Copyright (C) 2019 Ali Nouri, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Ali Nouri <alinouri1979@gmail.com>,  10, 17, 2019, 5:50 PM
*
***********************************************************************************/

using DevExpress.UserSkins;
using System;
using System.Windows.Forms;

namespace Localization
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new SelectedLanguageForm());
        }
    }
}