using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UiCommon;

namespace WebFormsUI
{
    public abstract class PageBase : System.Web.UI.Page
    {
        private DataController m_DataController;
        public PageBase()
        {
            this.m_DataController = new DataController(this);
        }
    }
}