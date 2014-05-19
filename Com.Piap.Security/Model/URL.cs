using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Piap.Security.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class URL : Resource
    {
        /// <summary>
        /// URL路径
        /// </summary>
        public string Path { set; get; }

        public URL() {
            this.Path = "";
        }
    }
}
