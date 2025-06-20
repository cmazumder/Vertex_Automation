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

namespace Ragnarok.UserInterface.Progressive
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EditProgressive recording.
    /// </summary>
    [TestModule("cda0afbd-36f6-41a2-bb4b-e693970aa271", ModuleType.Recording, 1)]
    public partial class EditProgressive : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Ragnarok.ObjectRepository repository.
        /// </summary>
        public static global::Ragnarok.ObjectRepository repo = global::Ragnarok.ObjectRepository.Instance;

        static EditProgressive instance = new EditProgressive();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditProgressive()
        {
            txt_ProgressiveName = "Progressive_1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditProgressive Instance
        {
            get { return instance; }
        }

#region Variables

        string _txt_ProgressiveName;

        /// <summary>
        /// Gets or sets the value of variable txt_ProgressiveName.
        /// </summary>
        [TestVariable("823107ff-db34-419d-b7fd-26e59ceb05dc")]
        public string txt_ProgressiveName
        {
            get { return _txt_ProgressiveName; }
            set { _txt_ProgressiveName = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Vertex.AristocratVertexWebUI.Form143077288.Progressive.Edit_FirstProgressive'.", repo.Vertex.AristocratVertexWebUI.Form143077288.Progressive.Edit_FirstProgressiveInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.Vertex.AristocratVertexWebUI.Form143077288.Progressive.Edit_FirstProgressiveInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Edit') on item 'Vertex.AristocratVertexWebUI.Form143077288.Progressive.Edit_FirstProgressive'.", repo.Vertex.AristocratVertexWebUI.Form143077288.Progressive.Edit_FirstProgressiveInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Vertex.AristocratVertexWebUI.Form143077288.Progressive.Edit_FirstProgressiveInfo, "Text", "Edit");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Vertex.AristocratVertexWebUI.Form143077288.Monitor.MonitorTabs.Edit' at 12;6.", repo.Vertex.AristocratVertexWebUI.Form143077288.Monitor.MonitorTabs.EditInfo, new RecordItemIndex(2));
            repo.Vertex.AristocratVertexWebUI.Form143077288.Monitor.MonitorTabs.Edit.Click("12;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'Vertex.AristocratVertexWebUI'.", repo.Vertex.AristocratVertexWebUI.SelfInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.Vertex.AristocratVertexWebUI.Self);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'Vertex.AristocratVertexWebUI'.", repo.Vertex.AristocratVertexWebUI.SelfInfo, new RecordItemIndex(4));
            repo.Vertex.AristocratVertexWebUI.Self.EnsureVisible();
            Keyboard.Press("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$txt_ProgressiveName' on item 'Vertex.AristocratVertexWebUI.Form143077288.Progressive.ProgressiveName'.", repo.Vertex.AristocratVertexWebUI.Form143077288.Progressive.ProgressiveNameInfo, new RecordItemIndex(5));
            repo.Vertex.AristocratVertexWebUI.Form143077288.Progressive.ProgressiveName.Element.SetAttributeValue("Text", txt_ProgressiveName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'Vertex.AristocratVertexWebUI'.", repo.Vertex.AristocratVertexWebUI.SelfInfo, new RecordItemIndex(6));
            repo.Vertex.AristocratVertexWebUI.Self.EnsureVisible();
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
