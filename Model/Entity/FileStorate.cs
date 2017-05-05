using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{ 
    public class FileStorate : Entity
    {
        /// <summary>
        /// 
        /// </summary>
        public string FileID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FileUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FileType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> FileHeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> FileWidth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FileSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FileTthumbnailUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AssociatedID { get; set; }
    }
}
