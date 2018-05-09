﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SolisTech.FRSAdminPortal.Common
{
    public class Logger
    {
        private static Logger logger;
        private ILog log;
        public static Logger Instance
        {
            get
            {
                if (logger == null)
                {
                    logger = new Logger();
                }
                return logger;
            }
        }

        protected Logger()
        {

        }

        private void Initialize()
        {
            log = LogManager.GetLogger(typeof(Logger));
            log4net.Config.XmlConfigurator.Configure();
        }

        public void Error(Exception ex, [CallerMemberName]string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (log == null)
                Initialize();
            log.Error(string.Format("Error logged From method {0} in file {1} at line {2}", memberName, sourceFilePath, sourceLineNumber), ex);
        }

        public void Warning(Exception ex, [CallerMemberName]string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (log == null)
                Initialize();
            log.Warn(string.Format("Warning From method {0} in file {1} at line {2}", memberName, sourceFilePath, sourceLineNumber), ex);

        }

        public void Debug(Exception ex, [CallerMemberName]string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (log == null)
                Initialize();
            log.Debug(string.Format("Debug entry From method {0} in file {1} at line {2}", memberName, sourceFilePath, sourceLineNumber), ex);
        }

        public void Infor(string info)
        {
            if (log == null)
                Initialize();

            log.Debug(info);
        }
    }
}
