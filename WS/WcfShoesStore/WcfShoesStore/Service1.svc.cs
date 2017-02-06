using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfShoesStore
{
    public class Service1 : IService1
    {


        public IEnumerable<tbl_Stores> GetStores()
        {
            List<tbl_Stores> li = new List<tbl_Stores>();
            StoreContext sc = new StoreContext();
            li = sc.Stores.ToList();
            return li;       
        }

        public void AddStore(tbl_Stores sobj)
        {
            StoreContext sc = new StoreContext();
            sc.Stores.Add(sobj);
            sc.SaveChanges();
        }

        public void ModifyStore(tbl_Stores sobj)
        {
            StoreContext sc = new StoreContext();
            var s = (from sto in sc.Stores
                     where sto.storeId == sobj.storeId
                     select sto).First();
            s.storeName     = sobj.storeName;
            s.storeAddress = sobj.storeAddress;
            sc.SaveChanges();
        }

        public void RemoveStore(int id)
        {
            StoreContext sc = new StoreContext();
            var s = (from sto in sc.Stores
                     where sto.storeId == id
                     select sto).First();
            sc.Stores.Remove(s);
            sc.SaveChanges();
        }

        public IEnumerable<tbl_Articles> GetArticles()
        {
            List<tbl_Articles> li = new List<tbl_Articles>();
            StoreContext ar = new StoreContext();
            li = ar.Articles.ToList();
            return li;
        }

        public void AddArticle(tbl_Articles sobj)
        {
            StoreContext sc = new StoreContext();
            sc.Articles.Add(sobj);
            sc.SaveChanges();
        }

        public void ModifyArticle(tbl_Articles sobj)
        {
            StoreContext sc = new StoreContext();
            var s = (from sto in sc.Articles 
                     where sto.articleId == sobj.articleId
                     select sto).First();
            s.articleName = sobj.articleName;
            s.articleDescription = sobj.articleDescription;
            s.articlePrice = sobj.articlePrice;
            s.articleTotalInShelf = sobj.articleTotalInShelf;
            s.articleTotalInVault = sobj.articleTotalInVault;
            s.storeId = sobj.storeId;
            sc.SaveChanges();
        }

        public void RemoveArticle(int id)
        {
            StoreContext sc = new StoreContext();
            var s = (from sto in sc.Articles
                     where sto.articleId == id
                     select sto).First();
            sc.Articles.Remove(s);
            sc.SaveChanges();
        }

        public Article GetArticle(int id)
        {
            StoreContext sc = new StoreContext();
            Article article = new Article();
            var s = (from art in sc.Articles
                     join sto in sc.Stores
                     on art.storeId equals sto.storeId
                     where art.articleId == id
                     select new { art.articleId, art.articleName, art.articleDescription, art.articlePrice, art.articleTotalInShelf, art.articleTotalInVault, sto.storeName }).First();
            article.articleId = s.articleId;
            article.articleName = s.articleName;
            article.articleDescription = s.articleDescription;
            article.articlePrice = s.articlePrice;
            article.articleTotalInShelf = s.articleTotalInShelf;
            article.articleTotalInVault = s.articleTotalInVault;
            article.storeName = s.storeName;

            return (article);
        }
    }
}
