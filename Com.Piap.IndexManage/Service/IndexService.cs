using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Com.Piap.IndexManage.IService;
using Com.Piap.IndexManage.IPersist;
using Com.Piap.IndexManage.Model;

namespace Com.Piap.IndexManage.Service {
    /// <summary>
    /// 指标领域类
    /// </summary>
    public class IndexService : IIndexService {
        /// <summary>
        /// 
        /// </summary>
        public IIndexPersist indexPersist { set; get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index_persist"></param>
        public IndexService(IIndexPersist index_persist) {
            this.indexPersist = index_persist;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CreateIndex(Index index) {
            return indexPersist.Create(index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Modify(Index index) {
            return indexPersist.Modify(index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Remove(Index index) {
            return indexPersist.Remove(index);
        }
    }
}
