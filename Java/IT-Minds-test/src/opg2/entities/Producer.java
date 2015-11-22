package opg2.entities;

import java.util.List;

public class Producer {

	private int id;
	private String name;
	private String description;
	private List<Product> products;
	
	public Producer(String name, String description) {
		this.name = name;
		this.description = description;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}
	
	public List<Product> getProducts() {
		return products;
	}

	public void setProducts(List<Product> products) {
		if (products == null) {
			this.products.clear();
			return;
		}
		this.products = products;
	}
	
	public void addProduct(Product p) {
		products.add(p);
	}
	
	@Override
	public String toString() {
		return name + " - " + description;
	}
}
