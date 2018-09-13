package induk.soft.cs2a.model;

import java.util.ArrayList;

public interface ProductDAO extends DAO {
	int insert(ProductDTO dto); // create
	ProductDTO select(ProductDTO dto); // read one record
	ArrayList<ProductDTO> selectList(ProductDTO dto); // read multi record
	int update(ProductDTO dto); // update 
	int delete(ProductDTO dto); // delete
}
