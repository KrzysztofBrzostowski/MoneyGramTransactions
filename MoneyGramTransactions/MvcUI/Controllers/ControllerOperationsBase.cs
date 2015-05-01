using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UiCommon;

namespace MvcUI.Controllers
{
    public class ControllerOperationsBase : Controller
    {
        protected DataController m_DataController;

        public ControllerOperationsBase()
        {
            m_DataController = new DataController(this);
        }
    }
}