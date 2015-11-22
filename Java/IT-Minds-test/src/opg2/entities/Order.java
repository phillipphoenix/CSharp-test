package opg2.entities;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class Order {
	
	private int id;
	private List<Product> products;
	private Customer customer;
	private Date orderDate;
	private double totalPrice;
	private String currency;
	private Address deliveryAddress;
	private String trackAndTraceNb;
	private OrderStatus status;

	public Order(Customer customer, String currency, Address deliveryAddress, OrderStatus status) {
		this.products = new ArrayList<Product>();
		this.customer = customer;
		this.totalPrice = 0;
		this.currency = currency;
		this.deliveryAddress = deliveryAddress;
		this.status = status;
		
		// Add order to customer's list of orders.
		this.customer.addOrder(this);
	}

	public int getId() {
		return id;
	}
	
	public void setId(int id) {
		this.id = id;
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
		// Update the total price.
		totalPrice = 0;
		for (Product product : products) {
			Price price = product.getCurrentPrice();
			if (price != null) {
				totalPrice += product.getCurrentPrice().getValue();
			}
		}
	}
	
	public void addProduct(Product p) {
		products.add(p);
		// Update the total price.
		Price price = p.getCurrentPrice();
		if (price != null) {
			totalPrice += p.getCurrentPrice().getValue();
		}
		
	}

	public Customer getCustomer() {
		return customer;
	}

	public void setCustomer(Customer customer) {
		this.customer = customer;
	}
	
	public Date getOrderDate() {
		return orderDate;
	}

	public void setOrderDate(Date orderDate) {
		this.orderDate = orderDate;
	}

	public double getTotalPrice() {
		return totalPrice;
	}

	public String getCurrency() {
		return currency;
	}

	public void setCurrency(String currency) {
		this.currency = currency;
	}

	public Address getDeliveryAddress() {
		return deliveryAddress;
	}

	public void setDeliveryAddress(Address deliveryAddress) {
		this.deliveryAddress = deliveryAddress;
	}

	public String getTrackAndTraceNb() {
		return trackAndTraceNb;
	}

	public void setTrackAndTraceNb(String trackAndTraceNb) {
		this.trackAndTraceNb = trackAndTraceNb;
	}

	public OrderStatus getStatus() {
		return status;
	}

	public void setStatus(OrderStatus status) {
		this.status = status;
	}

	public enum OrderStatus {
		UNSHIPPED, SHIPPED, CANCELLED
	}
	
	@Override
	public String toString() {
		String result =  id + " - " + customer.getFullName() + System.getProperty("line.separator");
		for (Product product : products) {
			result += product.getName() + ": " + product.getCurrentPrice() + System.getProperty("line.separator");
		}
		result += "Total price: " + totalPrice;
		return result;
	}
}
