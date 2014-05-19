/*
 * 
 * 
 */
namespace Com.Piap.Security.Model {

    /// <summary>
    /// 权限许可
    /// </summary>
    public class Permission {
        #region Fields

        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SubjectId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PrivilegeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Owned { get; set; }

        #endregion
    }
}
