/*
 * Created by Ranorex
 * User: Vertex
 * Date: 5/9/2019
 * Time: 5:50 PM
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
using Ranorex.Core.Repository; // must include repository to use RepoItemInfo objects

namespace Ragnarok
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class CustomActions
    {
        // You can use the "Insert New User Code Method" functionality from the right-click context menu,
        // to add a new method with the attribute [UserCodeMethod].

        [UserCodeMethod]
        public static void ClickIfExists(RepoItemInfo repoItem)
        {
        	Duration timeout = new Duration(120000); //this will override the object's "effective timeout" property
        	
        	Report.Info("Waiting 2 min for the repository item: " +repoItem.FullName+ " to exist. If it does I will click it!");
        	
        	if(repoItem.Exists(timeout))
        		repoItem.CreateAdapter<Unknown>(false).Click(); //if the element exists, click it, if not we do nothing after 2 min wait
        	
        }
    }
}
