/****************************** Ali Nouri ******************************\
*	Module Name:	Form1.cs
*	Project:		Localization
*	Copyright (C) 2019 Ali Nouri, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Ali Nouri <alinouri1979@gmail.com>,  10, 17, 2019, 5:50 PM
*
***********************************************************************************/

namespace Localization
{
    using System.Windows.Forms;

    public partial class SelectedLanguageForm : DevExpress.XtraEditors.XtraForm
    {
        public SelectedLanguageForm()
        {
            InitializeComponent();
        }

        private void EnglishSimpleButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FarsiSimpleButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SetCulture("fa");
            Close();
        }

        private static void SetCulture(string name)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(name);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(name);
            Properties.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;
        }
    }
}