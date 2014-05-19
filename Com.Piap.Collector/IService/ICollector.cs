/*
 * 
 * 
 */
namespace Com.Piap.Collector.IService {
    /// <summary>
    /// 采集器接口
    /// </summary>
    interface ICollector {
        /// <summary>
        /// 采集
        /// </summary>
        /// <returns></returns>
        bool Collect();
    }
}
