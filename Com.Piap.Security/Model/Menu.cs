/*
 * 
 * 
 */
namespace Com.Piap.Security.Model {

    /// <summary>
    /// 
    /// </summary>
    public class Menu  {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Leaf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ImagePath { get; set; }
        #endregion
    }
}
