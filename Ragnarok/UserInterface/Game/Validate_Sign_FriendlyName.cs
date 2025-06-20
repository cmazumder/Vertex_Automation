﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace Ragnarok.UserInterface.Game
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validate_Sign_FriendlyName recording.
    /// </summary>
    [TestModule("8546432e-e833-4e36-a173-011542fb1046", ModuleType.Recording, 1)]
    public partial class Validate_Sign_FriendlyName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Ragnarok.ObjectRepository repository.
        /// </summary>
        public static global::Ragnarok.ObjectRepository repo = global::Ragnarok.ObjectRepository.Instance;

        static Validate_Sign_FriendlyName instance = new Validate_Sign_FriendlyName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Sign_FriendlyName()
        {
            txt_sign_friendlyName = "SIGN NAME";
            txt_SignName = "SIGN NAME";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_Sign_FriendlyName Instance
        {
            get { return instance; }
        }

#region Variables

        string _txt_sign_friendlyName;

        /// <summary>
        /// Gets or sets the value of variable txt_sign_friendlyName.
        /// </summary>
        [TestVariable("1cfd6724-a16f-4c81-9f16-88a9826577ce")]
        public string txt_sign_friendlyName
        {
            get { return _txt_sign_friendlyName; }
            set { _txt_sign_friendlyName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable txt_SignName.
        /// </summary>
        [TestVariable("399573e3-b988-47ae-8470-ad5245565291")]
        public string txt_SignName
        {
            get { return repo.txt_SignName; }
            set { repo.txt_SignName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Vertex.AristocratVertexWebUI.Form143077288.Monitor.MonitorTabs.Edit3' at 45;12.", repo.Vertex.AristocratVertexWebUI.Form143077288.Monitor.MonitorTabs.Edit3Info, new RecordItemIndex(0));
            repo.Vertex.AristocratVertexWebUI.Form143077288.Monitor.MonitorTabs.Edit3.Click("45;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$txt_SignName) on item 'Vertex.AristocratVertexWebUI.Form143077288.Games.SignFriendlyName'.", repo.Vertex.AristocratVertexWebUI.Form143077288.Games.SignFriendlyNameInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Vertex.AristocratVertexWebUI.Form143077288.Games.SignFriendlyNameInfo, "Text", txt_SignName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Vertex.AristocratVertexWebUI.Form143077288.Casino.AddNewCasino.Cancel' at 62;12.", repo.Vertex.AristocratVertexWebUI.Form143077288.Casino.AddNewCasino.CancelInfo, new RecordItemIndex(2));
            repo.Vertex.AristocratVertexWebUI.Form143077288.Casino.AddNewCasino.Cancel.Click("62;12");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
