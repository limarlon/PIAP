/*
 * 
 * 
 */
namespace Com.Piap.Security.Model {

    /// <summary>
    /// 
    /// </summary>
    public class Privilege {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ActionId { get; set; }
        /// <summary>
        /// resource
        /// </summary>
        public string ProtectedObject { get; set; }

        #endregion
    }
}
