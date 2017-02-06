CREATE VIEW [dbo].[v_Articles]
	AS Select 
	A.articleId,
	A.articleName,
	A.articleDescription,
	A.articlePrice,
	A.articleTotalInShelf,
	A.articleTotalInVault,
	S.storeName
from tbl_Articles A 
Join tbl_Stores S on A.storeId = S.storeId