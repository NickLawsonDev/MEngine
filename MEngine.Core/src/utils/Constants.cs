using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEngine.Core
{
    public static class Constants
    {
        //Window Properties
        public static readonly int HEIGHT = 600;
        public static readonly int WIDTH = 800;
        public static readonly string TITLE = "MEngine";
        public static readonly bool ALLOWUSERRESIZING = true;
        public static readonly bool ISBORDERLESS = false;
        public static readonly bool VSYNC = false;

        //Game Properties
        public static readonly bool ISDEBUG = true;
        public static readonly bool ISFIXEDTIMESTEP = false;
    }
}
