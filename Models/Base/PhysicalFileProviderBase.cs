﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.EJ2.FileManager.Base;
using System.Web.Mvc;
using System.Web;


namespace Syncfusion.EJ2.FileManager.Base
{
    public interface PhysicalFileProviderBase : FileProviderBase
    {        
        void RootFolder(string folderName);
        void SetRules(AccessDetails details);
    }
}