using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfShoesStore
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<tbl_Stores> GetStores();

        [OperationContract]
        void AddStore(tbl_Stores sobj);

        [OperationContract]
        void ModifyStore(tbl_Stores sobj);

        [OperationContract]
        void RemoveStore(int id);


        [OperationContract]
        IEnumerable<tbl_Articles> GetArticles();

        [OperationContract]
        Article GetArticle(int id);

        [OperationContract]
        void AddArticle(tbl_Articles sobj);

        [OperationContract]
        void ModifyArticle(tbl_Articles sobj);

        [OperationContract]
        void RemoveArticle(int id);
    }

    [DataContract]
    public class tbl_Stores
    {

        [DataMember]
        [Key]
        [Required]
        public int storeId { get; set; }

        [DataMember]
        [Required]
        public string storeName { get; set; }

        [DataMember]
        [Required]
        public string storeAddress { get; set; }
      
    }

    [DataContract]
    public class tbl_Articles
    {
        [DataMember]
        [Key]
        [Required]
        public int articleId { get; set; }

        [DataMember]
        [Required]
        public int storeId { get; set; }

        [DataMember]
        [Required]
        public string articleName { get; set; }

        [DataMember]
        [Required]
        public string articleDescription { get; set; }

        [DataMember]
        [Required]
        public string articlePrice { get; set; }

        [DataMember]
        [Required]
        public string articleTotalInShelf { get; set; }

        [DataMember]
        [Required]
        public string articleTotalInVault { get; set; }
    }

    [DataContract]
    public class Article
    {
        [DataMember]
        [Required]
        public int articleId { get; set; }

        [DataMember]
        [Required]
        public string storeName { get; set; }

        [DataMember]
        [Required]
        public string articleName { get; set; }

        [DataMember]
        [Required]
        public string articleDescription { get; set; }

        [DataMember]
        [Required]
        public string articlePrice { get; set; }

        [DataMember]
        [Required]
        public string articleTotalInShelf { get; set; }

        [DataMember]
        [Required]
        public string articleTotalInVault { get; set; }

    }
}
