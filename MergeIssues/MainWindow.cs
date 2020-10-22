/*
 * Created by Ranorex
 * User: jbranham
 * Date: 10/22/2020
 * Time: 12:24 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MergeIssues
{
    /// <summary>
    /// Description of MainWindow.
    /// </summary>
    [TestModule("1352336B-8F36-4CCC-89CE-73A798C1298B", ModuleType.UserCode, 1)]
    public class MainWindow : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MainWindow()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
